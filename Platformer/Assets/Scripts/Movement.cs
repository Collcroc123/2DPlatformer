using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D m_Rigidbody;
    float m_Speed;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_Speed = 5.0f;
    }

    void Update()
    {
        /*if (Input.GetKeyDown("d"))
        {
            m_Rigidbody.velocity = transform.right * m_Speed;
        }

        if (Input.GetKeyDown("a"))
        {
            m_Rigidbody.velocity = -transform.right * m_Speed;
        }

        if (Input.GetKeyDown("w"))
        {
            m_Rigidbody.velocity = transform.up * m_Speed;
        }

        if (Input.GetKeyDown("s"))
        {
            m_Rigidbody.velocity = -transform.up * m_Speed;
        }*/
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (x, y);

        m_Rigidbody.velocity = (movement * m_Speed);

        //Vector3 mouseScreen = Input.mousePosition;
        //Vector3 mouse = Camera.main.ScreenToWorldPoint(mouseScreen);
        //transform.rotation = Quaternion.Euler(0, 0, Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg - 90);
    }
}
