using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretPlatform : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Secret Wall
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.oof);
            GetComponent<SpriteRenderer>().color = new Color(255f, 255f, 255f, 255f);
        }
    }
}
