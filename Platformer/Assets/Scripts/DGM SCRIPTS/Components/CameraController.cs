using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    Camera playerCam;


    // Start is called before the first frame update
    void Start()
    {
        playerCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        playerCam.fieldOfView = playerCam.fieldOfView - 0.01f;
    }
}
