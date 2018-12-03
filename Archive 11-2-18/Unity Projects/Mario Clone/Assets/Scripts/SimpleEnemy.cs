using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

<<<<<<< HEAD
    Animator animator;

    private SpriteRenderer spriteRenderer;

    private float Speed;

    Vector3 offset;
    Vector3 offset2;
=======
    public Sprite Explosion1;
    public Sprite Explosion2;
    public Sprite Explosion3;
    public Sprite Explosion4;

    private SpriteRenderer spriteRenderer;

    float timeLeft = .4f;
>>>>>>> 434f59cb9ffb999d3c29b8fed9f6bebe0adc8e2a

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;
        horizontalMove = true;
<<<<<<< HEAD

        //Fetch the Animator from your GameObject
        animator = GetComponent<Animator>();
=======
>>>>>>> 434f59cb9ffb999d3c29b8fed9f6bebe0adc8e2a
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        offset = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(Vector3.forward /*Keep z+ pointing straight into the screen.*/, offset /*Point y+ toward the target.*/);

        offset2 = target.position - transform.position;

        // Construct a rotation as in the y+ case.
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, offset2);

        // Apply a compensating rotation that twists x+ to y+ before the rotation above.
        transform.rotation = rotation * Quaternion.Euler(0, 0, 0);

        Speed = speed * Time.deltaTime;
=======
        float Speed = speed * Time.deltaTime;
>>>>>>> 434f59cb9ffb999d3c29b8fed9f6bebe0adc8e2a

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
<<<<<<< HEAD
            animator.SetTrigger("Hit");
            Speed = 0;
            this.GetComponent<PolygonCollider2D>().enabled = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Explosion);
            Destroy(gameObject, .5f); //Delete the enemy
        }

        if (collision.tag == "Speed Enemy")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.YoureTooSlow);
            Speed += 2;
=======
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
>>>>>>> 434f59cb9ffb999d3c29b8fed9f6bebe0adc8e2a
        }
    }
}
