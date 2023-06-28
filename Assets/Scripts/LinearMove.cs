using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMove : MonoBehaviour
{
    float speed = 10;
    int count = 0;
    Rigidbody2D rbody2D;
    Transform tr;
    [SerializeField] Vector2 v2 = Vector2.left;
    Vector3 v3;

    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        rbody2D.velocity = v2;
    }

    void Update()
    {
        
    }
}
