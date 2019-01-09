using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    private bool isPaused = false;



    public GUISkin guiSkin;
    Texture2D background, LOGO;
    public bool DragWindow = false;
    public string levelToLoadWhenClickedPlay = "SampleScene";
    public string[] AboutTextLines = new string[0];


    private string clicked = "", MessageDisplayOnAbout = "About \n ";
    private Rect WindowRect = new Rect((Screen.width / 2) - 250, Screen.height / 2 + 60, 200, 100);
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

    }

    void OnGUI()
    {
        WindowRect = GUI.Window(0, WindowRect, VictoryScreen, "You Won!");
    }

    private void VictoryScreen(int id)
    {
        if (GUILayout.Button("Replay"))
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
}
