using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float targetTime = 1.2f;
    public float targetTime2 = 1.2f;
    public float DeathtargetTime = 2f;
    public bool laserOn;
    public bool Ded;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        laserOn = true;
        Ded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (laserOn == true)
        {
            this.GetComponent<BoxCollider2D>().enabled = true;
            targetTime -= Time.deltaTime;
            //if (targetTime >= 1.19f)
            //{
            //    AudioManager.Instance.PlayOneShot(SoundEffect.LaserPowerUpDown);
            //}
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }

        if (laserOn == false)
        {
            this.GetComponent<BoxCollider2D>().enabled = false;
            targetTime2 -= Time.deltaTime;
            if (targetTime2 <= 0.0f)
            {
                timerEnded2();
            }
        }

        //if (Ded == true)
        //{
        //    gameObject.GetComponent<Character>().Velocity = new Vector3(gameObject.GetComponent<Character>().Velocity.x * (1 - Time.deltaTime * 0), gameObject.GetComponent<Character>().Velocity.y, 0);
        //    DeathtargetTime -= Time.deltaTime;
        //    if (DeathtargetTime <= 0.0f)
        //    {
        //        DeathtimerEnded();
        //    }
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Character>().alive = false;
            //Ded = true;
            //this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    //When the timer ends
    void timerEnded()
    {
        laserOn = false;
        targetTime2 = 1.2f;
        spriteRenderer.color = new Color(45f / 255, 77f / 255, 255f / 255, 0f / 255);
    }

    //When the second timer ends
    void timerEnded2()
    {
        spriteRenderer.color = new Color(45f / 255, 77f / 255, 255f / 255, 255f / 255);
        laserOn = true;
        targetTime = 1.2f;
    }

    //When the second timer ends
    void DeathtimerEnded()
    {
        gameObject.GetComponent<Character>().alive = false;
    }
}
