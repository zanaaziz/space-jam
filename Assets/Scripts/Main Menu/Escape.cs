using UnityEngine;
using System.Collections;

public class Escape : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey("escape")){
			Application.LoadLevel(0);
            Rock.ScoreData = 0;
            Rock.Lives = 5f;
		}	
	}
}
