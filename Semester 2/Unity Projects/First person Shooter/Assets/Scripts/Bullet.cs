using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    Quaternion tossDirection;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = GameManager.Instance.player.transform.position;
        tossDirection = GameManager.Instance.look;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


    }
}
