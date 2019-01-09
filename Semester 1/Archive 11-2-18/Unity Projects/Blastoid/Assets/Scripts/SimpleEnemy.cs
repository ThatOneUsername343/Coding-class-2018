using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public float speed;
    private bool horizontalMove;

    Animator animator;

    private SpriteRenderer spriteRenderer;

    private float Speed;

    Vector3 offset;
    Vector3 offset2;

    // Use this for initialization
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startPos = transform.position;
        horizontalMove = true;

        //Fetch the Animator from your GameObject
        animator = GetComponent<Animator>();

        if (target == null)
        {
            target = GameManager.Instance.Character.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        offset = target.position - transform.position;

        transform.rotation = Quaternion.LookRotation(Vector3.forward /*Keep z+ pointing straight into the screen.*/, offset /*Point y+ toward the target.*/);

        offset2 = target.position - transform.position;

        // Construct a rotation as in the y+ case.
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, offset2);

        // Apply a compensating rotation that twists x+ to y+ before the rotation above.
        transform.rotation = rotation * Quaternion.Euler(0, 0, 0);

        Speed = speed * Time.deltaTime;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        //All enemies
        if (other.tag == "Bullet")
        {
            animator.SetTrigger("Hit");
            speed = 0;
            this.GetComponent<PolygonCollider2D>().enabled = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Explosion);
            Destroy(gameObject, .5f); //Delete the enemy
        }

        if (other.tag == "Speed Enemy")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.YoureTooSlow);
            speed += 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<Character>().alive = false;
        }
    }
}
