using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * Speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * Speed);
        transform.Translate(movement);
		
		// Horizontal Screen Wrap.
		if(transform.position.x <= -85.3f){
			transform.position = new Vector3(85.3f, transform.position.y, transform.position.z);
		}
		
		else if(transform.position.x >= 85.3f){
			transform.position = new Vector3(-85.3f, transform.position.y, transform.position.z);
		}
		
		// Vertical Screen Wrap.
		if(transform.position.y <= -59f){
			transform.position = new Vector3(transform.position.x, 59f, transform.position.z);
		}
		
		else if(transform.position.y >= 59f){
			transform.position = new Vector3(transform.position.x, -59f, transform.position.z);
		}
	}
}
