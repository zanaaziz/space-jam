using UnityEngine;
using System.Collections;

public class WinGame : MonoBehaviour {

    float DeathTimer = 5f;

	// Update is called once per frame
	void Update () {
	
        if(Application.loadedLevel == 1 && Rock.ScoreData >= 50f){

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if(DeathTimer <= 0f)
            {
                Rock.ScoreData = 0;
                Application.LoadLevel(2);
            }

            if(Rock.Lives < 5)
            {

                Rock.Lives++;
            }
        }

        else if (Application.loadedLevel == 2 && Rock.ScoreData >= 75f)
        {

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if (DeathTimer <= 0f)
            {
                Rock.ScoreData = 0;
                Application.LoadLevel(3);
            }

            if (Rock.Lives < 5)
            {

                Rock.Lives++;
            }
        }

        else if (Application.loadedLevel == 3 && Rock.ScoreData >= 150f)
        {

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if (DeathTimer <= 0f)
            {
                Rock.ScoreData = 0;
                Application.LoadLevel(4);
            }

            if (Rock.Lives < 5)
            {

                Rock.Lives++;
            }
        }

        else if (Application.loadedLevel == 4 && Rock.ScoreData >= 200f)
        {

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if (DeathTimer <= 0f)
            {
                Rock.ScoreData = 0;
                Application.LoadLevel(5);
            }

            if (Rock.Lives < 5)
            {

                Rock.Lives++;
            }
        }

        else if (Application.loadedLevel == 5 && Rock.ScoreData >= 300f)
        {

            // Delay.
            DeathTimer = DeathTimer - 1f * Time.deltaTime;

            if (DeathTimer <= 0f)
            {
                Rock.ScoreData = 0;
                Application.LoadLevel(0);
            }

            if (Rock.Lives < 5)
            {

                Rock.Lives++;
            }
        }
	}
}
