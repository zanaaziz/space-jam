using UnityEngine;
using System.Collections;

public class LevelPrompt : MonoBehaviour {

    public GUISkin Skin;
    float LevelDisplayTime = 3f;
    bool Display = true;

    void OnGUI() {

        GUI.skin = Skin;

        if(Display == true){
        GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 400f, 100f), "" + Application.loadedLevelName);
        }
    }

    void Update() {

        LevelDisplayTime = LevelDisplayTime - 1f * Time.deltaTime;

        if(LevelDisplayTime <= 0f){

            Display = false;
        }
    }
}
