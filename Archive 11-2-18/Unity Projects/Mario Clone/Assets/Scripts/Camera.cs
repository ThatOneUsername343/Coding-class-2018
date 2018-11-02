using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Camera : MonoBehaviour
{
    public GameObject character;
    Vector3 goalvector = new Vector3();
    float hspeed = 3f;
    float vspeed = 1.6f;

    //Camera shake
    bool isShaking;
    float shakeTimer = 0;
    float shakeTimerGoal;
    float shakeIntensity;
    Vector3 positionSmoothRef;
    float sizeSmoothRef;
    Vector3 targetPos;
    float targetSize;
    Vector3 oldPosition;
    //bool Shaking;
    //float ShakeDecay;
    //float ShakeIntensity;
    //Vector3 OriginalPos;
    //Quaternion OriginalRot;
    //private List<CameraTarget> Targets
    //{ get; set; }

    //public Camera Cam
    //{ get; set; }

    //public void ApplyCameraShake(float intensity, float duration = 0)
    //{
    //    //We ignore applying a camera shake if the current intensity is higher that what is input. (so explosion shakes don't get cancled out by gunshot shakes)
    //    if (shakeIntensity < intensity * Constants.CAMERA_SHAKE_MULTIPLIER)
    //    {
    //        isShaking = true;
    //        shakeTimer = 0;
    //        shakeTimerGoal = duration;
    //        shakeIntensity = intensity * Constants.CAMERA_SHAKE_MULTIPLIER;
    //    }
    //}

    //public void StopCameraShake()
    //{
    //    isShaking = false;
    //}

    // Use this for initialization
    void Start()
    {
        //Shaking = false;
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        goalvector = new Vector3(character.transform.position.x, character.transform.position.y, -10);

        goalvector += new Vector3(character.GetComponent<Rigidbody2D>().velocity.x, character.GetComponent<Rigidbody2D>().velocity.y);

        Vector3 velocity = goalvector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hspeed, velocity.y * Time.deltaTime * vspeed, 0);

        //targetPos = GameManager.Instance.Character.transform.position + (GameManager.Instance.Character.Velocity * Constants.CAMERA_VELOCITY_WEIGHT_MULTIPLIER); //maybe add a modifier depending on which way the player is facing
        //foreach (CameraTarget c in Targets)
        //{
        //    targetPos += Vector3.LerpUnclamped(GameManager.Instance.Player.transform.position, c.target.position, c.priority);
        //}
        //targetPos /= Targets.Count + 1;
        //targetPos -= Vector3.forward * 10;
        //oldPosition = transform.position;
        //transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref positionSmoothRef, Constants.CAMERA_POSITION_SMOOTH_TIME);

        //Cam.orthographicSize = Mathf.Clamp(Mathf.SmoothDamp(Cam.orthographicSize, Mathf.Lerp(Constants.CAMERA_ORTHO_SIZE_MIN, Constants.CAMERA_ORTHO_SIZE_MAX, ((Vector2.Distance(transform.position, GameManager.Instance.Character.transform.position) / Constants.CAMERA_DISTANCE_MAX_FOR_ORTHO_CAM) + ((transform.position - oldPosition).magnitude / Constants.CAMERA_MAGNITUDE_MAX_FOR_ORTHO_CAM)) / 2), ref sizeSmoothRef, Constants.CAMERA_SIZE_SMOOTH_TIME), Constants.CAMERA_ORTHO_SIZE_MIN, Constants.CAMERA_ORTHO_SIZE_MAX);

        ////Shake if needed
        //if (isShaking)
        //{
        //    shakeTimer += Time.deltaTime;
        //    transform.position += (Vector3)Random.insideUnitCircle * shakeIntensity;
        //    shakeIntensity *= Constants.CAMERA_SHAKE_DAMPENER_MULTIPLIER;
        //    if (shakeTimer >= shakeTimerGoal)
        //    {
        //        shakeIntensity = 0;
        //        isShaking = false;
        //    }
        //}
        ////Camera shake
        //if (ShakeIntensity > 0)
        //{
        //    transform.position = OriginalPos + Random.insideUnitSphere * ShakeIntensity;
        //    transform.rotation = new Quaternion(OriginalRot.x + Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
        //                              OriginalRot.y + Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
        //                              OriginalRot.z + Random.Range(-ShakeIntensity, ShakeIntensity) * .2f,
        //                              OriginalRot.w + Random.Range(-ShakeIntensity, ShakeIntensity) * .2f);

        //    ShakeIntensity -= ShakeDecay;
        //}

        //else if (Shaking)
        //{
        //    Shaking = false;
        //}
    }

    

    //void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 200, 50, 30), "Shake"))
    //        DoShake();
    //    Debug.Log("Shake");
    //}

    //public void DoShake()
    //{
    //    OriginalPos = transform.position;
    //    OriginalRot = transform.rotation;

    //    ShakeIntensity = 0.3f;
    //    ShakeDecay = 0.02f;
    //    Shaking = true;
    //}
}
