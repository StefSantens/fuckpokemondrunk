using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            endText.on = 1;
            if (gameObject.tag != "Collidable")
                gameObject.SetActive(false);
        }
    }
}
