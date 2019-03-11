using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ChibiBehav : MonoBehaviour
{
    //Jumping/hopping stuff
    public bool canJump;
    public bool canHop;
    public bool FacingLeft;
    public bool touchingGround;
    public float maxTime = 6;
    public float minTime = 1;
    private float time;
    private float HopTime;
    public float ChibiSpeed = 1;
    public Vector2 hopHeightRight = new Vector2(0, 0);
    public Vector2 hopHeightLeft = new Vector2(0 * -1, 0);
    public Vector2 jumpHeight = new Vector2(0, 0);

    private Vector3 screenPoint;
    private Vector3 offset;

    public Vector3 Velocity = new Vector3(0, 0, 0);

    public Rigidbody2D rbody;

    public Sprite sticker_1; // Drag your first sprite here
    public Sprite sticker_2; // Drag your second sprite here
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start()
    {
        FacingLeft = true;
        canJump = false;
        canHop = true;

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sticker_1; // set the sprite to sticker1

        rbody = GetComponent<Rigidbody2D>();

        SetRandomTime();
        time = minTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Chibi hop timer stuffs
        if (touchingGround == true)
        {
            //rbody.freezeRotation = true;
            //if (transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 0 || transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 180)
            //{
            canHop = true;
            ChibiSpeed = 1;

            //Counts up
            time += Time.deltaTime;

            //Check if its the right time for the chibi to hop
            if (time >= HopTime)
            {
                Hop();
                SetRandomTime();
            }
            //}
        }

        else
        {
            canHop = false;
            canJump = false;
        }

        Velocity = rbody.velocity;
    }

    //When the chibi randomly hops and all that goodness
    void ChibiHop()
    {
        FacingLeft = (Random.Range(0, 2) == 0);

        if (FacingLeft == true)
        {
            transform.Translate(ChibiSpeed * Time.deltaTime, 0f, 0f);  //makes chibi run
            GetComponent<Rigidbody2D>().AddForce(hopHeightLeft, ForceMode2D.Impulse); //Makes chibi jump

            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (FacingLeft == false)
        {
            //Velocity += Vector3.up * jump;
            //Velocity -= Vector3.left * speed * Time.deltaTime;
            transform.Translate(ChibiSpeed * Time.deltaTime, 0f, 0f);  //makes chibi run
            GetComponent<Rigidbody2D>().AddForce(hopHeightRight, ForceMode2D.Impulse); //Makes chibi jump

            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    //Spawns the object and resets the time
    void Hop()
    {
        time = minTime;
        ChibiHop();
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        HopTime = Random.Range(minTime, maxTime);
    }

    //If touching something
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            //if (transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 0 || transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 180)
            //{
            touchingGround = true;
            //}
        }
    }

    //If no longer touching something
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            touchingGround = false;
        }
    }

    //Change the sprite when character jumps
    void ChangeTheSprite()
    {
        if (spriteRenderer.sprite == sticker_1) // if the spriteRenderer sprite = sticker_1 then change to sticker_2
        {
            spriteRenderer.sprite = sticker_2;
        }

        else
        {
            spriteRenderer.sprite = sticker_1; // otherwise change it back to sticker_1
        }
    }

    //If mouse is touching the collider
    void OnMouseEnter()
    {
        if (touchingGround == true)
        {
            //if (transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 0 || transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 180)
            //{
            canJump = true;
            ChangeTheSprite();
            //}

            //Jumping
            if (canJump == true)
            {
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse); //Makes chibi jump
            }
        }
        canHop = false;
    }

    //If mouse is not touching collider
    void OnMouseExit()
    {
        if (touchingGround == true)
        {
            //if (transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 0 || transform.rotation.eulerAngles.x <= 0 && transform.rotation.eulerAngles.z <= 0 && transform.rotation.eulerAngles.y <= 180)
            //{
            ChangeTheSprite();
            //}
        }
    }

    //When you pick up the chibi
    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        //rbody.freezeRotation = false;
    }

    //When you drag the chibi around while holding her
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    //When you release the chibi from your grasp
    private void OnMouseUp()
    {
        
    }
}
