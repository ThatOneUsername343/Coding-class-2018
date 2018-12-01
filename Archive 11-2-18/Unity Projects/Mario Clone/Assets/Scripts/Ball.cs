using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector3 Velocity = new Vector3(0, 0, 0);

    //public GameObject explosion;

    [SerializeField]
    float speed = 1f;

    // Use this for initialization
    void Start()
    {
        Velocity.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Velocity * Time.deltaTime * speed;
        //if (transform.position.y > 1)
        //{
        //    Velocity = Vector3.Reflect(Velocity, Vector3.down);
        //    transform.position = new Vector3(transform.position.x, 1, 0);
        //}
        //if (transform.position.x < -1.75f)
        //{
        //    Velocity = Vector3.Reflect(Velocity, Vector3.right);
        //    transform.position = new Vector3(-1.75f, transform.position.y, 0);
        //}
        //if (transform.position.y < -1)
        //{
        //    Velocity = Vector3.Reflect(Velocity, Vector3.up);
        //    transform.position = new Vector3(transform.position.x, -1, 0);
        //}
        //if (transform.position.x > 1.75f)
        //{
        //    Velocity = Vector3.Reflect(Velocity, Vector3.left);
        //    transform.position = new Vector3(1.75f, transform.position.y, 0);
        //}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            //GameObject expl = Instantiate(explosion) as GameObject;
            Destroy(gameObject); //Delete the rocket
            //Destroy(expl, 3); // delete the explosion after 3 seconds
        }

        if (collision.tag == "Enemy")
        {
            //GameObject expl = Instantiate(explosion) as GameObject;
            Destroy(gameObject); //Delete the rocket
            //Destroy(expl, 3); // delete the explosion after 3 seconds
        }
    }
}
