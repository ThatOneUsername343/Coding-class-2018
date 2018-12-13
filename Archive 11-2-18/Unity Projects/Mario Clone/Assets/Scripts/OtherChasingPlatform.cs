using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherChasingPlatform : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

    private bool isTouching = false;

    //Audio Proximity Stuffs
    //public Transform audioTarget;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        horizontalMove = true;

        ////Audio Stuffs
        //StartCoroutine(AdjustVolume());
    }

    // Update is called once per frame
    void Update()
    {
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


        //Stuff to determine if it is touching the first Chasing Platform
        if (isTouching == true)
        {
            speed = .75f;
        }

        if (isTouching == false)
        {
            speed = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Character>().alive = false;
            Time.timeScale = 0;
        }

        if (other.gameObject.tag == "Chasing Platform")
        {
            isTouching = true;
        }
    }
}
