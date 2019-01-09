using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPlatform : MonoBehaviour
{
    [SerializeField]
    public GameObject Coin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject coin = Instantiate(Coin, new Vector3(34.382f, -21.783f, 0), Quaternion.identity);

            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
