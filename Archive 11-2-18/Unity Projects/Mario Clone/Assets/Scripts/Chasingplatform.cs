using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Object = UnityEngine.Object;

public class Chasingplatform : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

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
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Character>().alive = false;
            Time.timeScale = 0;
        }
    }

    //IEnumerator AdjustVolume()
    //{
    //    while (true)
    //    {
    //        if (AudioSource.isPlaying)
    //        { // do this only if some audio is being played in this gameObject's AudioSource

    //            float distanceToTarget = Vector3.Distance(transform.position, target.position); // Assuming that the target is the player or the audio listener

    //            if (distanceToTarget < 1) { distanceToTarget = 1; }

    //            AudioSource.volume = 1 / distanceToTarget; // this works as a linear function, while the 3D sound works like a logarithmic function, so the effect will be a little different (correct me if I'm wrong)

    //            yield return new WaitForSeconds(1); // this will adjust the volume based on distance every 1 second (Obviously, You can reduce this to a lower value if you want more updates per second)

    //        }
    //    }
    //}
}
