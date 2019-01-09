using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    private bool isPaused = false;

    public GUISkin guiSkin;
    Texture2D background, LOGO;
    public bool DragWindow = false;
    public string levelToLoadWhenClickedPlay = "SampleScene";
    public string[] AboutTextLines = new string[0];


    private string clicked = "", MessageDisplayOnAbout = "About \n ";
    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 100);
    private float volume = 1.0f;
    private float SFXvolume = 1f;
    private float BGMvolume = 1f;

    public static bool pause;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (/*clicked == "about" &&*/ Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            clicked = "";
        }

        //if (Input.GetKeyDown(KeyCode.Escape)) //If the player presses Esc then the value of isPaused becomes the opposite. (Translated from French)
        //{
        //    isPaused = !isPaused;
        //}

        //if (isDead)
        //{
        //    Time.timeScale = 0; //Stops time
        //    AudioListener.pause = true;
        //    mySpriteRenderer.enabled = true;
        //}

        //else
        //{
        //    Time.timeScale = 1; //Starts time
        //    AudioListener.pause = false;
        //    mySpriteRenderer.enabled = false;
        //}
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (objectCollider.IsTouching(anotherCollider))
    //    {
    //        isDead = true;
    //    }

    //    if (objectCollider.IsTouching(anotherCollider2))
    //    {
    //        isDead = true;
    //    }

    //    if (objectCollider.IsTouching(anotherCollider3))
    //    {
    //        isDead = true;
    //    }
    //}

    void OnGUI()
    {
        //if (background != null)
        //    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);

        //if (LOGO != null)
        //    GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), LOGO);

        //GUI.skin = guiSkin;

        WindowRect = GUI.Window(0, WindowRect, deathScreen, "You died!");

        //if (isDead)
        //{
        //    WindowRect = GUI.Window(0, WindowRect, deathScreen, "You died!");
        //}

        //if (clicked == "options")
        //{
        //    WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        //}

        //else if (clicked == "about")
        //{
        //    GUI.Box(new Rect(0, 0, Screen.width, Screen.height), MessageDisplayOnAbout);
        //}

        //else if (clicked == "resolution")
        //{
        //    GUILayout.BeginVertical();

        //    for (int x = 0; x < Screen.resolutions.Length; x++)
        //    {
        //        if (GUILayout.Button(Screen.resolutions[x].width + "X" + Screen.resolutions[x].height))
        //        {
        //            Screen.SetResolution(Screen.resolutions[x].width, Screen.resolutions[x].height, true);
        //        }
        //    }

        //    GUILayout.EndVertical();
        //    GUILayout.BeginHorizontal();

        //    if (GUILayout.Button("Back"))
        //    {
        //        clicked = "options";
        //    }

        //    GUILayout.EndHorizontal();
        //}
    }

    //Game over screen
    private void deathScreen(int id)
    {
        if (GUILayout.Button("Retry"))
        {
            //string sceneName = PlayerPrefs.GetString("SampleScene");
            //SceneManager.LoadScene(sceneName);//back to previous scene1?
            SceneManager.LoadScene("SampleScene"/*, LoadSceneMode.Additive*/);
        }

        if (GUILayout.Button("Quit"))
        {
            Application.Quit();
        }

        //if (DragWindow)
        //    GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    }

    ////If options is clicked
    //private void optionsFunc(int id)
    //{
    //    if (GUILayout.Button("Resolution"))
    //    {
    //        clicked = "resolution";
    //    }

    //    GUILayout.Box("Master Volume");
    //    volume = GUILayout.HorizontalSlider(volume, 0.0f, 2.0f);
    //    AudioListener.volume = volume;

    //    GUILayout.Box("SFX Volume");
    //    SFXvolume = GUILayout.HorizontalSlider(SFXvolume, 0.0f, 2.0f);
    //    AudioManager.Instance.SoundEffectSource.volume = SFXvolume;

    //    GUILayout.Box("BGM Volume");
    //    BGMvolume = GUILayout.HorizontalSlider(BGMvolume, 0.0f, 2.0f);
    //    AudioManager.Instance.BGMSource.volume = BGMvolume;

    //    if (GUILayout.Button("Back"))
    //    {
    //        clicked = "";
    //    }

    //    if (DragWindow)
    //        GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    //}

    ////Pause menu stuff
    //private void menuFunc(int id)
    //{
    //    if (isPaused == true)
    //    {
    //        //buttons 
    //        if (GUILayout.Button("Play Game"))
    //        {
    //            //play game is clicked
    //            //SceneManager.LoadScene(levelToLoadWhenClickedPlay);
    //            isPaused = false;
    //        }

    //        if (GUILayout.Button("Options"))
    //        {
    //            clicked = "options";
    //        }

    //        //if (GUILayout.Button("About"))
    //        //{
    //        //    clicked = "about";
    //        //}

    //        if (GUILayout.Button("Quit Game"))
    //        {
    //            Application.Quit();
    //        }

    //        if (DragWindow)
    //            GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    //    }
    //}
}
