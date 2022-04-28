using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Rigidbody2D _rb;
    public Rigidbody2D _Target;

    public void Start()
    {
        GameObject player = GameObject.Find("Player");
        _Target = player.GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        var x = new Vector2((_Target.position.x- _rb.position.x), (_Target.position.y - _rb.position.y));
        _rb.velocity = x;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
