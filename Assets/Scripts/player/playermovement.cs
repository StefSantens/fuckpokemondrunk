using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Animator animator;
    public float moveSpeed = 5.0f;
    public Rigidbody2D _rb;
    public float maxX = 2.5f;
    public float maxY = 3f;

    private void Update()
    {
        var horizontalMovement = Input.GetAxisRaw("Horizontal");
        var verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 test = new Vector3(horizontalMovement, verticalMovement, 0.0f);
        //transform.position = transform.position + test;
        if (test.x > 0)
        {
            animator.SetTrigger("Right");
            
        }
        else if (test.x < 0)
        {
            animator.SetTrigger("Left");
        }
        else if (test.y > 0)
        {
            animator.SetTrigger("Up");
        }
        else if (test.y < 0)
        {
            animator.SetTrigger("Down");
        }
        _rb.velocity = new Vector2(test.x, test.y)*moveSpeed;
    }

}