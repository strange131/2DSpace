using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horiz : MonoBehaviour
{
    [SerializeField] float leftlimit = -11;
    [SerializeField] float rightlimit = 11;

    void Update()
    {
        if (transform.position.x < leftlimit)
        {
            transform.position = new Vector3(
                rightlimit,
                transform.position.y,
                transform.position.z
                );
        }
    }
}
