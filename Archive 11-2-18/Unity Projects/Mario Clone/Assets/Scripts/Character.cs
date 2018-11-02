using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    public List<Vector3> teleportlocations = new List<Vector3>();

    [SerializeField]
    GameObject ballPrefab;
    float jump = 5.5f;
    float speed = 7;
    bool canJump = true;
    bool FacingRight = false;
    float Timer = 0;

    //Shooting
    float TimeToReach = 0;
    float timeBetweenShots = .25f;
    float timeBetweenShotsCounter = .25f;
    bool canShoot;

    //Background music
    bool BackgroundStartPlaying = true;

    Vector3 reset = new Vector3(-1.52f, -0.5f, 0);

    Vector3 Velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        canShoot = true;
        timeBetweenShotsCounter = timeBetweenShots;
        rbody = GetComponent<Rigidbody2D>();
        
        GameManager.Instance.Character = this;
        BackgroundStartPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        ////Background music loop
        //if (BackgroundStartPlaying == false)
        //{
        //    AudioManager.Instance.PlayOneShot(BackGroundMusic.BackgroundRepeat);
        //}

        //Shooting
        if (Input.GetMouseButton(0) && canShoot)
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            Velocity += LookAtDirection(transform.eulerAngles.z);

            //Shooting left
            if (FacingRight == false)
            {

                newBall.GetComponent<Ball>().Velocity = -LookAtDirection(transform.eulerAngles.z);
                newBall.transform.localRotation = Quaternion.Euler(0, 180, 0);
                AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
                canShoot = false;
            }

            //Shooting right
            if (FacingRight == true)
            {
                newBall.GetComponent<Ball>().Velocity = LookAtDirection(transform.eulerAngles.z);
                AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
                canShoot = false;
            }

            //Changing colors of rockets
            newBall.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            if (Timer > TimeToReach)
            {
                newBall.GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            }
        }

        //Fire rate
        if (!canShoot)
        {
            timeBetweenShotsCounter -= Time.deltaTime;
            if (timeBetweenShotsCounter <= 0)
            {
                canShoot = true;
                timeBetweenShotsCounter = timeBetweenShots;
            }
        }

        if (Input.GetKey(KeyCode.G))
        {
            GameManager.Instance.Character = this;
        }
        Velocity = rbody.velocity;

        //Jumping
        if (Input.GetKeyDown(KeyCode.W) && canJump)
        {
            Velocity += Vector3.up * jump;
            canJump = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
        }

        //Moving left
        if (Input.GetKey(KeyCode.A))
        {
            Velocity -= Vector3.right * speed * Time.deltaTime;
            FacingRight = false;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        //Moving right
        if (Input.GetKey(KeyCode.D))
        {
            Velocity -= Vector3.left * speed * Time.deltaTime;
            FacingRight = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Velocity = new Vector3(Velocity.x * (1 - Time.deltaTime * 5), Velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(Velocity.x, -2f, 2f), Mathf.Clamp(Velocity.y, -4f, jump), 0);
    }

    //Teleporting
    public void OnClickTeleportButton()
    {
        transform.position = teleportlocations[Random.Range(0, teleportlocations.Count)];
    }

    //Waiting to hit ground before can jump again
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            canJump = true;
        }
    }

    //Lava
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            transform.position = reset;
            AudioManager.Instance.PlayOneShot(SoundEffect.Death);
            speed = 7;
        }
    }

    private void OnCollisionEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SecretWall"))
        {
            GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
    }
    
public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }
}
