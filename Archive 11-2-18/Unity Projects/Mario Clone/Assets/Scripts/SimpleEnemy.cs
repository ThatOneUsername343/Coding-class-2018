using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

    public Sprite Explosion1;
    public Sprite Explosion2;
    public Sprite Explosion3;
    public Sprite Explosion4;

    private SpriteRenderer spriteRenderer;

    float timeLeft = .4f;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;
        horizontalMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = speed * Time.deltaTime;

        if (transform.position == target.position)
        {
            horizontalMove = true;
        }
        //else if (transform.position == startPos)
        //{
        //    horizontalMove = true;
        //}
        //if (horizontalMove == false)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, startPos, Speed);
        //}
        if (horizontalMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //All enemies
        if (collision.tag == "Bullet")
        {
            Destroy(gameObject); //Delete the enemy

            //timeLeft -= Time.deltaTime;
            //if (timeLeft == .4)
            //{
            //    spriteRenderer.sprite = Explosion1;
            //}

            //if (timeLeft == .3)
            //{
            //    spriteRenderer.sprite = Explosion2;
            //}

            //if (timeLeft == .2)
            //{
            //    spriteRenderer.sprite = Explosion3;
            //}

            //if (timeLeft == .1)
            //{
            //    spriteRenderer.sprite = Explosion4;
            //}

            //if (timeLeft == 0)
            //{
            //    Destroy(gameObject); //Delete the enemy
            //}
        }
        
        //Speed Enemies
        if (tag == "Speed Enemy" && collision.tag == "Player")
        {
            Destroy(gameObject);
        }
        else if (tag == "Speed Enemy" && collision.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
