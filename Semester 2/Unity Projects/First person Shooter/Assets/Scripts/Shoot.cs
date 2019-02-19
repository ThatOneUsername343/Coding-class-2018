using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody projectile;

    public float speed = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));

        }
    }
    //[SerializeField]
    //GameObject bullet;

    //float TimeToReach = 0;
    //float timeBetweenShots = .25f;
    //float timeBetweenShotsCounter = .25f;
    //bool canShoot;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    canShoot = true;
    //    timeBetweenShotsCounter = timeBetweenShots;
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse1))
    //    {
    //        Instantiate(bullet);
    //        //Shooting
    //        if (Input.GetMouseButton(0) && canShoot)
    //        {
    //            GameObject newBall = Instantiate(bullet);
    //            newBall.transform.position = transform.position;
    //            Velocity += LookAtDirection(transform.eulerAngles.z);
    //            newBall.GetComponent<RifleBullet>().Velocity = LookAtDirection(transform.eulerAngles.z);
    //            newBall.transform.localRotation = Quaternion.Euler(0, 0, 270);
    //            canShoot = false;

    //            ////Shooting left
    //            //if (FacingRight == false)
    //            //{
    //            //    newBall.GetComponent<Ball>().Velocity = -LookAtDirection(transform.eulerAngles.z);
    //            //    newBall.transform.localRotation = Quaternion.Euler(0, 0, 90);
    //            //    AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
    //            //    canShoot = false;
    //            //}

    //            ////Shooting right
    //            //if (FacingRight == true)
    //            //{
    //            //    newBall.GetComponent<Ball>().Velocity = LookAtDirection(transform.eulerAngles.z);
    //            //    newBall.transform.localRotation = Quaternion.Euler(0, 0, 270);
    //            //    AudioManager.Instance.PlayOneShot(SoundEffect.Pew);
    //            //    canShoot = false;
    //            //}
    //        }

    //        //Fire rate
    //        if (!canShoot)
    //        {
    //            timeBetweenShotsCounter -= Time.deltaTime;
    //            if (timeBetweenShotsCounter <= 0)
    //            {
    //                canShoot = true;
    //                timeBetweenShotsCounter = timeBetweenShots;
    //            }
    //        }
    //    }
    //}
}
