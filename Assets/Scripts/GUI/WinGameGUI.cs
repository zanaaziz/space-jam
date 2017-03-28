using UnityEngine;
using System.Collections;

public class WinGameGUI : MonoBehaviour {

    public GUISkin Skin;

    void OnGUI() {

        GUI.skin = Skin;
    
        if(Application.loadedLevel == 1 && Rock.ScoreData >= 50f)
        {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Win");
        }

        else if (Application.loadedLevel == 2 && Rock.ScoreData >= 75f)
        {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Win");
        }

        else if (Application.loadedLevel == 3 && Rock.ScoreData >= 150f)
        {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Win");
        }

        else if (Application.loadedLevel == 4 && Rock.ScoreData >= 200f)
        {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Win");
        }

        else if (Application.loadedLevel == 5 && Rock.ScoreData >= 300f)
        {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Win");
        }
    }
}