using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour {

    public GUISkin skin;

    void OnGUI() {
        GUI.skin = skin;

        // Score Label.
        GUI.Label(new Rect(2.5f, 0f, 100f, 20f), "Score: " +Rock.ScoreData);

        // Lives Label.
        GUI.Label(new Rect(2.5f, 20f, 100f, 20f), "Lives: " + Rock.Lives);

        // Level Label.
        GUI.Label(new Rect(2.5f, 460f, 100f, 20f), "" + Application.loadedLevelName);
    }
}
