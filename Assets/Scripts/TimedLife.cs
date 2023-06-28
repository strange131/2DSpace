using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLife : MonoBehaviour
{
    [SerializeField] float time = 1;

    void Start()
    {
        Destroy(gameObject, time);
    }

    
    void Update()
    {
        
    }
}
