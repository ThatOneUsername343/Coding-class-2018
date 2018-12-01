using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //If the player presses Esc then the value of isPaused becomes the opposite. (Translated from French)
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Time.timeScale = 0; //Stops time
        }

        else
        {
            Time.timeScale = 1; //Starts time
        }
    }

    void OnGUI()
    {
        if (isPaused)
        {
            //If the button is pressed then isPaused becomes false so the game resumes. (Translated from French)
            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 60, 100, 40), "Continue"))
            {
                isPaused = false;
            }

            //If the button is presser then we completely close the game or load the scene "Main Menu" (Translated from French)
            //In the case of the button to leave it is necessary to increase its postion Y so that it is lower. (Translated from French)
            if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 + 00, 150, 40), "Load a different level"))
            {
                // Application.Quit(); 
                Application.LoadLevel(""); //Loads a different level
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 60, 100, 40), "Settings"))
            {
                if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 + 60, 100, 40), "SFX volume"))
                {

                }

                if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2, 100, 40), "Music volume"))
                {

                }

                if (GUI.Button(new Rect(Screen.width / 2, Screen.height / 2 - 60, 150, 40), "Change Background Music"))
                {

                }
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 120, 100, 40), "Quit"))
            {
                Application.Quit();
                //Application.LoadLevel(""); 
            }
        }
    }
}
