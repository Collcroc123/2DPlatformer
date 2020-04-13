using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderTime : MonoBehaviour
{
    Material material;
    //public Shader shader;
    float fade = 1f;

    // Start is called before the first frame update
    void Start()
    {
        material = new Material(Shader.Find("BurnShader"));
        //shader = GetComponent<Shader>();
    }

    // Update is called once per frame
    void Update()
    {
        fade -= Time.deltaTime;

        if (fade <=0f)
        {
            fade = 1f;
        }

        //gameObject.GetComponent<Renderer>().sharedMaterial.SetFloat("_fade", fade);
        //material.SetFloat("_fade", fade);
    }
}
