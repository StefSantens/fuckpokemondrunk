using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float moveSpeed;
    public bool isMoving;
    private Vector2 input;
    public float maxX = 2.5f;
    public float maxY = 3f;

    private void Update()
    {
        var horizontalMovement = Input.GetAxisRaw("Horizontal");
        var verticalMovement = Input.GetAxisRaw("Vertical");
        Vector3 test = new Vector3(horizontalMovement / 10f, verticalMovement / 10f, 0.0f);
        //if(test.x < maxX && test.y < maxY)
        //{
        //    transform.position = transform.position + test;
        //}
    }
}
