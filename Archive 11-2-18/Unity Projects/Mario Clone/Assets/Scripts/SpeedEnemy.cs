using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedEnemy : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

    Animator animator;

    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;
        horizontalMove = true;

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(
                               Vector3.forward, // Keep z+ pointing straight into the screen.
                               offset           // Point y+ toward the target.
                             );

        Vector3 offset2 = target.position - transform.position;

        // Construct a rotation as in the y+ case.
        Quaternion rotation = Quaternion.LookRotation(
                                  Vector3.forward,
                                  offset2
                              );

        // Apply a compensating rotation that twists x+ to y+ before the rotation above.
        transform.rotation = rotation * Quaternion.Euler(0, 0, 0);

        float Speed = speed * Time.deltaTime;

        if (transform.position == target.position)
        {
            horizontalMove = true;
        }

        if (horizontalMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, Speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            animator.SetTrigger("Hit");
            this.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(gameObject, .5f); //Delete the enemy
        }
        
        if (collision.tag == "Player")
        {
            animator.SetTrigger("Touch");
            this.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(gameObject, .5f); //Delete enemy
        }

        if (collision.tag == "Enemy")
        {
            animator.SetTrigger("Touch");
            this.GetComponent<PolygonCollider2D>().enabled = false;
            Destroy(gameObject, .5f); //Delete enemy
        }
    }
}
