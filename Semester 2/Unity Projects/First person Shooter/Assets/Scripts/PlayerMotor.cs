using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour
{


    [SerializeField]
    private Camera cam;
    private Vector3 velocity = Vector3.zero;
    private Rigidbody rb;
    private Vector3 rotation = Vector3.zero;
    private Vector3 cameraRotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Instance.player = rb;
        GameManager.Instance.look = Quaternion.LookRotation(cam.transform.rotation.eulerAngles);
    }

    //Gets a movement vector
    public void Move(Vector3 velocity2)
    {
        velocity = velocity2;
    }

    //Gets a rotational vector
    public void Rotate(Vector3 Rotation2)
    {
        rotation = Rotation2;
    }

    //Gets a rotational vector for the camera
    public void RotateCamera(Vector3 cameraRotation2)
    {
        cameraRotation = cameraRotation2;
    }

    //Runs every physics iteration
    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }

    //Perform movement based on velocity variable
    void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rb.MovePosition(transform.position + velocity * Time.fixedDeltaTime);
        }
    }

    //Perform rotation
    void PerformRotation()
    {
        rb.MoveRotation(transform.rotation * Quaternion.Euler(rotation));
        if (cam != null)
        {
            cam.transform.Rotate(cameraRotation);
        }
    }


}
