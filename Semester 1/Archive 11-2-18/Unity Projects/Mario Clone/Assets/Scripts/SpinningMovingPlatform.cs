using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningMovingPlatform : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        horizontalMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Spinning
        transform.Rotate(Vector3.back);

        //Moving to target
        float step = speed * Time.deltaTime;
        if (transform.position == target.position)
        {
            horizontalMove = false;
        }
        else if (transform.position == startPos)
        {
            horizontalMove = true;
        }
        if (horizontalMove == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, startPos, step);
        }
        else if (horizontalMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }
}
