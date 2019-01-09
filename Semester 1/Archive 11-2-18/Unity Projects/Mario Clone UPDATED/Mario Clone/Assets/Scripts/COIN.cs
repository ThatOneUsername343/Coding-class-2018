using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COIN : MonoBehaviour
{
    private Vector3 startPos;
    public Transform target;
    public Transform target2;
    public float speed;
    private bool horizontalMove;

    [SerializeField]
    public GameObject Coin;

    // Use this for initialization
    void Start()
    {
        startPos = transform.position;
        horizontalMove = true;

        if (target == null)
        {
            target = GameObject.FindWithTag("Coin Target 1").transform;
        }

        if (target2 == null)
        {
            target2 = GameObject.FindWithTag("Coin Target 2").transform;
        }
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
        else if (transform.position == target2.position)
        {
            horizontalMove = true;
        }

        if (horizontalMove == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, step);
        }
        else if (horizontalMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.CoinSound);
            Destroy(gameObject);
            collision.gameObject.GetComponent<Character>().GameFinished = true;
        }
    }
}
