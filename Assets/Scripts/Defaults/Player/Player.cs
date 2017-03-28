using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    bool Hit = false;
    float BlinkTimer = 2f;
    public GameObject PEX;
    public AudioClip[] DeathSFX;
	
	// Update is called once per frame
	void Update () {

        // Blinking.
        if (Hit == false)
        {
            GetComponent<Renderer>().enabled = true;
            GetComponent<Collider>().enabled = true;
        }

        if (Hit == true)
        {
            GetComponent<Renderer>().enabled = false;
            GetComponent<Renderer>().enabled = (Time.time % 0.2 > 0.1);
            GetComponent<Collider>().enabled = false;

            BlinkTimer = BlinkTimer - 1f * Time.deltaTime;
        }

        if (BlinkTimer < 0f)
        {
            Hit = false;
            BlinkTimer = 2f;
        }

        // Self destruct when lives are at 0.
        if (Rock.Lives <= 0)
        {
            Instantiate(PEX, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(DeathSFX[0], transform.position);
        }
	}

    void OnCollisionEnter(Collision PCol) { 
    
        // Blink
        if(PCol.gameObject.name == "Rock"){

            Hit = true;
        }
    }
}
