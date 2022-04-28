using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Animator animator;
    public AnimationClip Left;
    public AnimationClip Right;
    public AnimationClip Up;
    public AnimationClip Down;
    public AnimationClip Idle;
    public float moveSpeed = 5.0f;
    public Rigidbody2D _rb;
    public float maxX = 2.5f;
    public float maxY = 3f;

    private void Update()
    {
        var horizontalMovement = Input.GetAxisRaw("Horizontal");
        var verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 test = new Vector3(horizontalMovement, verticalMovement, 0.0f);
        if (test.x > 0)
        {
            animator.Play("RunningRight");
        }
        else if (test.x < 0)
        {
            animator.Play("RunningLeft");
        }
        else if (test.y > 0)
        {
            animator.Play("RunningUp");
        }
        else if (test.y < 0)
        {
            animator.Play("RunningDown");
        }
        if (test == Vector3.zero)
        {
            animator.Play("Idle");
        }
        _rb.velocity = new Vector2(test.x, test.y)*moveSpeed;
    }

}