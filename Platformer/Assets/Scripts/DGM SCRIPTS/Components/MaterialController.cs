using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialController : MonoBehaviour
{
    public Material coolMat;

    // Start is called before the first frame update
    void Start()
    {
        //coolMat = GetComponent<Material>();
        coolMat.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            coolMat.color = Color.blue;
        }
        if (Input.GetKeyDown("s"))
        {
            coolMat.color = Color.yellow;
        }
        if (Input.GetKeyDown("a"))
        {
            coolMat.color = Color.green;
        }
        if (Input.GetKeyDown("d"))
        {
            coolMat.color = Color.red;
        }
    }
}
