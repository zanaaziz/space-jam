using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        // Left
        if(Input.GetKeyDown("left")){

            transform.Rotate(0, 50f * Time.deltaTime, 0);
        }

        else if(Input.GetKeyUp("left")){

            transform.Rotate(0, 0, 0);
        }

        // Right
        if (Input.GetKey("right"))
        {

            Debug.Log("Right");
        }
	}
}
