using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;



    public GUISkin guiSkin;
    public Texture2D background, LOGO;
    public bool DragWindow = false;
    public string levelToLoadWhenClickedPlay = "SampleScene";
    public string[] AboutTextLines = new string[0];


    private string clicked = "", MessageDisplayOnAbout = "About \n ";
    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);
    private float volume = 1.0f;
    private float SFXvolume = 1f;
    private float BGMvolume = 1f;

    public static bool pause;

    // Use this for initialization
    void Start()
    {
        //for (int x = 0; x < AboutTextLines.Length; x++)
        //{
        //    MessageDisplayOnAbout += AboutTextLines[x] + " \n ";
        //}
        //MessageDisplayOnAbout += "Press Esc To Go Back";
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

        if (isPaused)
        {
            Time.timeScale = 0; //Stops time
            AudioListener.pause = true;
        }

        else
        {
            Time.timeScale = 1; //Starts time
            AudioListener.pause = false;
        }
    }

    void OnGUI()
    {
        //if (isPaused)
        //{
        //    //If the button is pressed then isPaused becomes false so the game resumes. (Translated from French)
        //    if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 60, 100, 40), "Continue"))
        //    {
        //        isPaused = false;
        //    }

        //    //If the button is presser then we completely close the game or load the scene "Main Menu" (Translated from French)
        //    //In the case of the button to leave it is necessary to increase its postion Y so that it is lower. (Translated from French)
        //    if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 00, 150, 40), "Load a different level"))
        //    {
        //        // Application.Quit(); 
        //        Application.LoadLevel(""); //Loads a different level
        //    }




        //if (background != null)
        //    GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), background);

        //if (LOGO != null && clicked != "about")
        //    GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), LOGO);

        GUI.skin = guiSkin;

        if (clicked == "" && isPaused)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
        }

        if (clicked == "options")
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }

        //else if (clicked == "about")
        //{
        //    GUI.Box(new Rect(0, 0, Screen.width, Screen.height), MessageDisplayOnAbout);
        //}

        else if (clicked == "resolution")
        {
            GUILayout.BeginVertical();

            for (int x = 0; x < Screen.resolutions.Length; x++)
            {
                if (GUILayout.Button(Screen.resolutions[x].width + "X" + Screen.resolutions[x].height))
                {
                    Screen.SetResolution(Screen.resolutions[x].width, Screen.resolutions[x].height, true);
                }
            }

            GUILayout.EndVertical();
            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Back"))
            {
                clicked = "options";
            }

            GUILayout.EndHorizontal();
        }

        //if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 60, 100, 40), "Settings"))
        //{
        //    if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 + 60, 100, 40), "SFX volume"))
        //    {

        //    }

        //    if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 100, 40), "Music volume"))
        //    {

        //    }

        //    if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 - 60, 150, 40), "Change Background Music"))
        //    {

        //    }
        //}

        //if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 120, 100, 40), "Quit"))
        //{
        //    Application.Quit();
        //    //Application.LoadLevel(""); 
        //}
    }

    //If options is clicked
    private void optionsFunc(int id)
    {
        if (GUILayout.Button("Resolution"))
        {
            clicked = "resolution";
        }

        GUILayout.Box("Master Volume");
        volume = GUILayout.HorizontalSlider(volume, 0.0f, 2.0f);
        AudioListener.volume = volume;

        GUILayout.Box("SFX Volume");
        SFXvolume = GUILayout.HorizontalSlider(SFXvolume, 0.0f, 2.0f);
        AudioManager.Instance.SoundEffectSource.volume = SFXvolume;

        GUILayout.Box("BGM Volume");
        BGMvolume = GUILayout.HorizontalSlider(BGMvolume, 0.0f, 2.0f);
        AudioManager.Instance.BGMSource.volume = BGMvolume;

        if (GUILayout.Button("Back"))
        {
            clicked = "";
        }

        if (DragWindow)
            GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
    }

    //Pause menu stuff
    private void menuFunc(int id)
    {
        if (isPaused == true)
        {
            //buttons 
            if (GUILayout.Button("Play Game"))
            {
                //play game is clicked
                //SceneManager.LoadScene(levelToLoadWhenClickedPlay);
                isPaused = false;
            }

            if (GUILayout.Button("Options"))
            {
                clicked = "options";
            }

            if (GUILayout.Button("Restart Level"))
            {
                SceneManager.LoadScene("SampleScene");
            }

            //if (GUILayout.Button("About"))
            //{
            //    clicked = "about";
            //}

            if (GUILayout.Button("Quit Game"))
            {
                Application.Quit();
            }

            if (DragWindow)
                GUI.DragWindow(new Rect(0, 0, Screen.width, Screen.height));
        }
    }
}
