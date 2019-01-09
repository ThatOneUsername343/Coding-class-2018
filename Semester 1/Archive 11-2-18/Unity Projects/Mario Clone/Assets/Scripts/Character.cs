using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Character : MonoBehaviour
{
    public List<Vector3> teleportlocations = new List<Vector3>();

    public float targetTime = 5f;

    public AudioSource audioSource;

    //Jumping
    public Sprite BirdHero_0; // Drag your first sprite here
    public Sprite BirdHero_1; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    public static bool pause;

    [SerializeField]
    GameObject ballPrefab;
    public float jump = 5.5f;
    public float speed = 7;
    public float maxSpeed = 35;
    public float curSpeed = 7;
    public float Timer = 0;

    bool canJump = true;
    bool FacingRight = false;

    bool SpeedEnemyTouch = false;

    //Shooting
    float TimeToReach = 0;
    float timeBetweenShots = .25f;
    float timeBetweenShotsCounter = .25f;
    bool canShoot;

    //Background music
    bool BackgroundStartPlaying = true;

    Vector3 reset = new Vector3(-1.52f, -0.5f, 0);

    public Vector3 Velocity = new Vector3(0, 0, 0);
    public Rigidbody2D rbody;

    public bool alive;

    // Use this for initialization
    void Start()
    {
        canShoot = true;
        timeBetweenShotsCounter = timeBetweenShots;
        rbody = GetComponent<Rigidbody2D>();

        GameManager.Instance.Character = this;
        BackgroundStartPlaying = false;

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = BirdHero_0; // set the sprite to BirdHero_0

        alive = true;

        AudioListener.pause = false;

        AudioManager.Instance.finishedGame = false;
    }

    // Update is called once per frame
    void Update()
    {
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
                newBall.transform.localRotation = Quaternion.Euler(0, 0, 90);
                AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
                canShoot = false;
            }

            //Shooting right
            if (FacingRight == true)
            {
                newBall.GetComponent<Ball>().Velocity = LookAtDirection(transform.eulerAngles.z);
                newBall.transform.localRotation = Quaternion.Euler(0, 0, 270);
                AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
                canShoot = false;
            }

            //Changing colors of bullets
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

        //Gamemanager stuffs
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
            ChangeTheSprite(); // call method to change sprite
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
        }

        //Moving left
        if (Input.GetKey(KeyCode.A))
        {
            Velocity -= Vector3.right * speed * Time.deltaTime;
            FacingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        //Moving right
        if (Input.GetKey(KeyCode.D))
        {
            Velocity -= Vector3.left * speed * Time.deltaTime;
            FacingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            Velocity = new Vector3(Velocity.x * (1 - Time.deltaTime * 5), Velocity.y, 0);
        }

        //THE CLAMPS!!!!
        //If the speed enemy has not touched you
        if (SpeedEnemyTouch == false)
        {
            rbody.velocity = new Vector3(Mathf.Clamp(Velocity.x, -2f, 2f), Mathf.Clamp(Velocity.y, -4f, jump), 0);
        }

        if (SpeedEnemyTouch == true)
        {
            targetTime -= Time.deltaTime;
            rbody.velocity = new Vector3(Mathf.Clamp(Velocity.x, -5f, 5f), Mathf.Clamp(Velocity.y, -3f, jump), 0);
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }

        //Death stuff
        if (alive == false)
        {
            //PlayerPrefs.SetString("lastLoadedScene", SceneManager.GetActiveScene().name);
            //SceneManager.LoadScene("BonusScene");
            Time.timeScale = 0;
            SceneManager.LoadScene("Game Over Scene"/*, LoadSceneMode.Additive*/);
            AudioManager.Instance.finishedGame = true;
            AudioManager.Instance.PlayOneShot(SoundEffect.Death, .2f);
            AudioManager.Instance.PlayOneShot(SoundEffect.MissionFailed);
        }
    }

    //Teleporting
    public void OnClickTeleportButton()
    {
        transform.position = teleportlocations[Random.Range(0, teleportlocations.Count)];
    }

    //Collisions and stuff
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            spriteRenderer.sprite = BirdHero_0;
            canJump = true;
        }

        if (collision.collider.tag == "Final Platform")
        {
            spriteRenderer.sprite = BirdHero_0;
            canJump = true;
        }

        if (collision.collider.tag == "Enemy")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.Death, .2f);
            alive = false;
        }

        if (collision.collider.tag == "Chasing Platform")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.Death, .2f);
        }
    }

    //If character isn't touching anything
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            spriteRenderer.sprite = BirdHero_1;
        }

        if (collision.collider.tag == "Final Platform")
        {
            spriteRenderer.sprite = BirdHero_1;
        }
    }

    //Lava
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            //transform.position = reset;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            alive = false;
            AudioManager.Instance.PlayOneShot(SoundEffect.Death, .2f);
            //speed = 7;
        }

        if (collision.gameObject.tag == "Speed Enemy")
        {
            AudioManager.Instance.PlayOneShot(SoundEffect.YoureTooSlow);

            //Speed enemy effect timer stuff
            SpeedEnemyTouch = true;
            speed = 7f;
        }
    }

    public Vector3 LookAtDirection(float eulerAnglesZ)
    {
        return new Vector3(Mathf.Cos(eulerAnglesZ * Mathf.Deg2Rad), Mathf.Sin(eulerAnglesZ * Mathf.Deg2Rad), 0);
    }

    //Change the sprite when character jumps
    void ChangeTheSprite()
    {
        if (spriteRenderer.sprite == BirdHero_0) // if the spriteRenderer sprite = BirdHero_0 then change to BirdHero_1
        {
            spriteRenderer.sprite = BirdHero_1;
        }

        else
        {
            spriteRenderer.sprite = BirdHero_0; // otherwise change it back to BirdHero_0
        }
    }

    //When the timer ends
    void timerEnded()
    {
        SpeedEnemyTouch = false;
    }
}
