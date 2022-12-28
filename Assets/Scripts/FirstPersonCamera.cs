using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    //public variables
    public Transform player;

    //private variables
    [SerializeField] private float mouseSensitivity = 2.0f;
    private float cameraVerticalRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //lock cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //mouse input
        float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        //rotate camera around x-axis
        cameraVerticalRotation -= inputY;
        cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90.0f, 90.0f); //prevents rotation beyond +/- 90 degrees
        transform.localEulerAngles = (Vector3.right * cameraVerticalRotation);

        //rotate camera and player around y-axis

        player.Rotate(Vector3.up * inputX);

    }
}
