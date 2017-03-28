using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	float Speed = 250f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(0, Speed * Time.deltaTime, 0);
		
		if(transform.position.y >= 70f || transform.position.y <= -70f){
			Destroy(gameObject);
		}
	}

    void OnCollisionEnter(Collision col) {

        if(col.gameObject.name == "Rock"){

            Destroy(gameObject);
        }
    }
}
