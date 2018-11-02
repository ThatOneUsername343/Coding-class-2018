using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Object = UnityEngine.Object;

public enum SoundEffect
{
    Jump,
    Death,
    Pew,
}
public enum BackGroundMusic
{
    BackgroundStart,
    BackgroundRepeat,
}
public class AudioManager
{
    static AudioManager instance;
    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }

    private Dictionary<BackGroundMusic, AudioClip> BackGroundSound
    { get; set; }

    private AudioSource SoundEffectSource
    { get; set; }

    private AudioSource BGMSource
    { get; set; }

    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager()); } }

    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("SoundEffects")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));

        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(SoundEffectSource.gameObject);

        BackGroundSound = Resources.LoadAll<AudioClip>("BackGroundMusic")
            .ToDictionary(t => (BackGroundMusic)Enum.Parse(typeof(BackGroundMusic), t.name, true));

        BGMSource = new GameObject("BGMSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .5f;
        BGMSource.loop = false;
        Object.DontDestroyOnLoad(BGMSource.gameObject);

        PlayOneShot(BackGroundMusic.BackgroundStart);
    }

    public void Update()
    {
        if (BGMSource.isPlaying)
        {
            Debug.Log("TRUE");
        }
    }

    public void PlayOneShot(SoundEffect sound, float volumeScale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumeScale * 1);
    }

    public void PlayOneShot(BackGroundMusic sound, float volumeScale = 1)
    {
        BGMSource.PlayOneShot(BackGroundSound[sound], volumeScale * 1);
    }

    public void ChangeBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}
