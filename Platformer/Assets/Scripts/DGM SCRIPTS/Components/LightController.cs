using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightController : MonoBehaviour
{
    Light coolLight;
    //Camera coolCamera;

    void Start()
    {
        coolLight = GetComponent<Light>();
        //coolCamera = GetComponent<Camera>();
        coolLight.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            coolLight.color = Color.blue;
        }
        if(Input.GetKeyDown("s"))
        {
            coolLight.color = Color.yellow;
        }
        if (Input.GetKeyDown("a"))
        {
            coolLight.color = Color.green;
        }
        if(Input.GetKeyDown("d"))
        {
            coolLight.color = Color.red;
        }
    }
}
