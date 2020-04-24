using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehaviour : MonoBehaviour
{
    public CharacterMovement cm;

    void Start()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    void Update()
    {
        if (cm.startJumping == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                GetComponent<Renderer> ().material.color = Color.red;
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }

            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
}