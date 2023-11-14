using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCollectable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //collision.gameObject;
        //Add a point to score
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
