using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWaitTime : MonoBehaviour
{

    public float waitTime = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartCam()
    {
        StartCoroutine(CamCoroutine());
    }

    public IEnumerator CamCoroutine()
    {
        print("Transitioning...");
        yield return new WaitForSeconds(waitTime);
        print("Done!");
    }
}
