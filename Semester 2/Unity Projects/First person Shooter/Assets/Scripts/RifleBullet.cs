using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBullet : MonoBehaviour
{
    private Rigidbody rb;
    Quaternion tossDirection;

    public Vector3 Velocity = new Vector3(0, 0, 0);

    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Velocity.Normalize();

        transform.position = GameManager.Instance.player.transform.position;
        tossDirection = GameManager.Instance.look;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Velocity * Time.deltaTime * speed;

    }
}
