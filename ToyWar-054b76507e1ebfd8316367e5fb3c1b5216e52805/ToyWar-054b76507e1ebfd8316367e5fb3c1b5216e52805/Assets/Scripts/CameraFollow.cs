using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform teddyBearPosition;
    public Transform camTransform;
   public Vector3 cameraOffset;
    private Camera cam;



    public float distance = 8.0f;
    public float currentX=0.0f;
    public float currentY = 0.0f;
    public float sensivityX = 4.0f;
    public float sensivityy = 1.0f;

    public const float Y_ANGLE_MIN = 0.0f;
    public const float Y_ANGLE_MAX = 50.0f;


    // maybe in the start() we put the animation of tha camera 
    void Start() {
        camTransform = transform;
        cam = Camera.main;
    }
    void Update() {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
    }
	// Upd ate is called once per frame
	void LateUpdate () {

        // transform.position = teddyBearPosition.position - cameraOffset;
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX,0);
        camTransform.position = teddyBearPosition.position + rotation * dir;
        camTransform.LookAt(teddyBearPosition.position);

    }
}
