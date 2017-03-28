using UnityEngine;
using System.Collections;

public class MenuGUI : MonoBehaviour{

	public GUISkin Skin;

    void OnGUI()
    {
		
		GUI.skin = Skin;
        
        // Play Game button.
        if (GUI.Button(new Rect((Screen.width / 2) - 150, (Screen.height / 2) + 75, 300, 30), "Play Game"))
        {
            Application.LoadLevel(1);
        }

        // Quit Game button.
        if (GUI.Button(new Rect((Screen.width / 2) - 150, (Screen.height / 2) + 125, 300, 30), "Quit Game"))
        {
            Application.Quit();
        }
    }
}