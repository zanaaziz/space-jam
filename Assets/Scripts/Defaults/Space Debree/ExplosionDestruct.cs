using UnityEngine;
using System.Collections;

public class ExplosionDestruct : MonoBehaviour {

    float Timer = 1f;
	
	// Update is called once per frame
	void Update () {

        Timer = Timer - 1 * Time.deltaTime;

        if(Timer < 0){

            Destroy(gameObject);
        }
	}
}
