using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] eggs;
    
    private float rad = .5f;
    private bool hasRunOnce= false;

    private void Update()
    {

        if (!hasRunOnce)
        {
            for (int i = 0; i < eggs.Length; i++)
            {
                Vector2 randomSpawnPosition = new Vector2(Random.Range(-15, 20), Random.Range(-12, 15));

                if (Physics2D.OverlapCircle(randomSpawnPosition, rad))
                {
                    // If the egg would hit a collider, find a new position
                    do
                    {
                        randomSpawnPosition = new Vector2(Random.Range(-15, 20), Random.Range(-12, 15));
                    } while (Physics2D.OverlapCircle(randomSpawnPosition, rad));
                }

                Instantiate(eggs[i], randomSpawnPosition, Quaternion.identity);
            }

            hasRunOnce = true; // Set the flag to indicate the block has run
        }


    }


    

}




