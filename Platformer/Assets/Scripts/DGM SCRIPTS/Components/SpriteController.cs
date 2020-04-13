using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteController : MonoBehaviour
{
    SpriteRenderer characterSprite;

    // Start is called before the first frame update
    void Start()
    {
        characterSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            characterSprite.color = Color.blue;
        }
        if (Input.GetKeyDown("s"))
        {
            characterSprite.color = Color.yellow;
        }
        if (Input.GetKeyDown("a"))
        {
            characterSprite.color = Color.green;
        }
        if(Input.GetKeyDown("d"))
        {
            characterSprite.color = Color.red;
        }
    }
}
