using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField]
    public GameObject simpleEnemy;
    public GameObject speedEnemy;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.tag == "Enemy Spawner 2")
        {
            if (collision.gameObject.tag == "Player")
            {
                GameObject enemy = Instantiate(simpleEnemy, new Vector3(17.41f, -8.63f, 0), Quaternion.identity);
                enemy = Instantiate(simpleEnemy, new Vector3(14.02f, -7.53f, 0), Quaternion.identity);
                //enemy = Instantiate(simpleEnemy, new Vector3(18.05f, -5.82f, 0), Quaternion.identity);
                enemy = Instantiate(simpleEnemy, new Vector3(18.6f, 2.45f, 0), Quaternion.identity);

                this.GetComponent<BoxCollider2D>().enabled = false;
            }
        }

        if(gameObject.tag == "Enemy Spawner 3")
        {
            if (collision.gameObject.tag == "Player")
            {
                GameObject enemy = Instantiate(simpleEnemy, new Vector3(14.37f, -10.52f, 0), Quaternion.identity);
                enemy = Instantiate(simpleEnemy, new Vector3(17.37f, -12.63f, 0), Quaternion.identity);
                //enemy = Instantiate(simpleEnemy, new Vector3(14.8f, -14.78f, 0), Quaternion.identity);
                enemy = Instantiate(speedEnemy, new Vector3(15.45f, -13.7f, 0), Quaternion.identity);
                enemy = Instantiate(simpleEnemy, new Vector3(14.98f, -15.48f, 0), Quaternion.identity);

                this.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
