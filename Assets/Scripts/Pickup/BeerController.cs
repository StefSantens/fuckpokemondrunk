using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            ScoreScript.scoreValue++;
            Debug.Log(gameObject);
            if (gameObject.tag != "Collidable")
            gameObject.SetActive(false);
            // Destroy(gameObject);
        }
    }
}
