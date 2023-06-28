using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCount : MonoBehaviour
{
    Rigidbody2D rbody2D;
    [SerializeField] float speed = 7;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float horiz = 0;
        float vert = 0;
        if (Input.GetKey(KeyCode.W))
        {
            vert = speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horiz = -speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vert = -speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            horiz = speed;
        }
        rbody2D.velocity = new Vector2(horiz, vert);
    }
}
