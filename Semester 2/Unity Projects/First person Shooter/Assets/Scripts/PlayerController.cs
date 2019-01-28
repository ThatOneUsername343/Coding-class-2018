using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float lookSensitivity = 1;

    public float jump = 5.5f;
    bool canJump = true;

    private PlayerMotor motor;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        //calculate rotation as a 3d vector (turning around)
        float yRot = Input.GetAxisRaw("Mouse X");
        //calculate camera rotation as a 3d vector (turning around)
        float xRot = Input.GetAxisRaw("Mouse Y");

        //calculate movement velocity as a 3d vector
        float xMove = Input.GetAxisRaw("Horizontal");
        float zMove = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * xMove;
        Vector3 moveVertical = transform.forward * zMove;

        //final movement vector
        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;

        //Apply Movement
        motor.Move(velocity);

        //calculate rotation as a 3d vector (turning around)
        Vector3 rotation = new Vector3(0, yRot, 0) * lookSensitivity;

        //apply rotation
        motor.Rotate(rotation);

        //calculate camera rotation as a 3d vector
        Vector3 cameraRotation = new Vector3(xRot, 0, 0) * lookSensitivity;

        //apply rotation
        motor.RotateCamera(-cameraRotation);

        //Sprinting
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20f;
        }
        else
        {
            speed = 10f;
        }

        ////Jumping
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    velocity = (moveHorizontal + moveVertical + Jump).normalized * speed;
        //    canJump = false;
        //}
    }

    //private void Movement()
    //{

    //    //Jumping
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        velocity = (moveHorizontal + moveVertical + Jump).normalized * speed;
    //        canJump = false;
    //    }
    //}
}
