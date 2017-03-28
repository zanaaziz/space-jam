using UnityEngine;
using System.Collections;

public class LostGame : MonoBehaviour {

    public GUISkin Skin;

    void OnGUI() {

        GUI.skin = Skin;

       if (Rock.Lives <= 0f)
       {
            GUI.Label(new Rect((Screen.width / 2), (Screen.height / 2), 400f, 100f), "You Lose");
       }
    }
}
