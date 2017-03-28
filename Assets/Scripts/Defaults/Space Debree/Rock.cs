using UnityEngine;
using System.Collections;

public class Rock : MonoBehaviour {
    
    public float MinSpeed;
    public float MaxSpeed;
    private float CurrentSpeed;
    public static float x, y, z;
    public static float ScoreData;
    public static float Lives = 5f;
    GameObject PlayerGO;
    public AudioClip[] RockX;
    float RotateX, RotateY, RotateZ;
    public GameObject Explosive;
    public GameObject PlayerExplosion;
    float DeathTimer = 5f;

    void Awake()
    {
        PlayerGO = GameObject.FindGameObjectWithTag("Player");
    }

	// Use this for initialization
	void Start () {

        // Generate speed.
        CurrentSpeed = Random.Range(MinSpeed, MaxSpeed);

        x = Random.Range(-70f, 70f);
        y = 70f;
        z = -10f;

        transform.position = new Vector3(x, y, z);
	}
	
	// Update is called once per frame
	void Update () {

        // Clear Rocks when level won.
        if (Application.loadedLevel == 1 && ScoreData >= 50f)
        {
            Instantiate(Explosive, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            Destroy(gameObject);
        }

        else if (Application.loadedLevel == 2 && ScoreData >= 75f)
        {
            Instantiate(Explosive, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            Destroy(gameObject);
        }

        else if (Application.loadedLevel == 3 && ScoreData >= 150f)
        {
            Instantiate(Explosive, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            Destroy(gameObject);
        }

        else if (Application.loadedLevel == 4 && ScoreData >= 200f)
        {
            Instantiate(Explosive, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            Destroy(gameObject);
        }

        else if (Application.loadedLevel == 5 && ScoreData >= 300f)
        {
            Instantiate(Explosive, transform.position, Quaternion.identity);
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            Destroy(gameObject);
        }

        // Losing game.
        if(Lives <= 0){

            Destroy(PlayerGO);

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if(DeathTimer <= 0f){
            Lives = 5f;
            ScoreData = 0;
            Application.LoadLevel(0);
            DeathTimer = 5f;
            }
        }

        // Moving rock down.
        transform.Translate(Vector3.down * CurrentSpeed * Time.deltaTime, Space.World);

        // Rock at bottom of screen.
        if(transform.position.y <= -70f){

            CurrentSpeed = Random.Range(MinSpeed, MaxSpeed);
            x = Random.Range(-70f, 70f);
            y = 70f;
            z = -10f;
            transform.position = new Vector3(x, y, z);

            ScoreData = ScoreData - 10f;
            Lives = Lives - 1f;
        }

        if (Lives < 0)
        {
            Lives = 0;
        }

        else if (ScoreData < 0)
        {
            ScoreData = 0;
        }

        // Rock rotation animation.
        RotateX = Random.Range(0.2f, 1f);
        RotateY = Random.Range(0.2f, 1f);
        RotateZ = Random.Range(0.2f, 1f);
        transform.Rotate(RotateX, RotateY, RotateZ);

	}

    void OnCollisionEnter(Collision col)
    {
        // Adding a score point.
        if (col.gameObject.name == "Projectile(Clone)")
        {
            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            CurrentSpeed = Random.Range(MinSpeed, MaxSpeed);
            x = Random.Range(-70f, 70f);
            Instantiate(Explosive, transform.position, Quaternion.identity);
            transform.position = new Vector3(x, y, z);
            ScoreData = ScoreData + 1f;
            RotateX = Random.Range(-0.6f, 0.6f);
            RotateY = Random.Range(-0.6f, 0.6f);
            RotateZ = Random.Range(-0.6f, 0.6f);
            transform.Rotate(RotateX, RotateY, RotateZ);
        }

        // Taking a live.
        else if (col.gameObject.name == "Player")
        {

            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            PlayerGO.transform.position = new Vector3(0, -40f, -10f);
            CurrentSpeed = Random.Range(MinSpeed, MaxSpeed);
            x = Random.Range(-70f, 70f);
            Instantiate(PlayerExplosion, transform.position, Quaternion.identity);
            Instantiate(Explosive, transform.position, Quaternion.identity);
            transform.position = new Vector3(x, y, z);
            RotateX = Random.Range(-0.6f, 0.6f);
            RotateY = Random.Range(-0.6f, 0.6f);
            RotateZ = Random.Range(-0.6f, 0.6f);
            transform.Rotate(RotateX, RotateY, RotateZ);
            Lives = Lives - 1f;

        }else{

            AudioSource.PlayClipAtPoint(RockX[0], transform.position);
            CurrentSpeed = Random.Range(MinSpeed, MaxSpeed);
            x = Random.Range(-70f, 70f);
            Instantiate(Explosive, transform.position, Quaternion.identity);
            transform.position = new Vector3(x, y, z);
            RotateX = Random.Range(-0.6f, 0.6f);
            RotateY = Random.Range(-0.6f, 0.6f);
            RotateZ = Random.Range(-0.6f, 0.6f);
            transform.Rotate(RotateX, RotateY, RotateZ);
        }
    }
}