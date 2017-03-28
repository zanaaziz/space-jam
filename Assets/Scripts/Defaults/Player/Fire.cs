using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {
	
	public GameObject Projectile;
	public AudioClip[] Blast;
	
	// Update is called once per frame
	void Update () {
	
    // Regular fire.
	if(Input.GetButtonDown("Fire")){

        Vector3 ProjectilePosFix = new Vector3(transform.position.x, transform.position.y + transform.localScale.y + 6, transform.position.z);

            AudioSource.PlayClipAtPoint(Blast[0], transform.position);
			Instantiate(Projectile, ProjectilePosFix, Quaternion.identity);
		}
	}
}
