using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShot : MonoBehaviour
{
    [SerializeField] GameObject shotPrefab = null;
    [SerializeField] Transform gun;
    [SerializeField] AudioSource attack = null;
    float r = 1.5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shotPrefab, gun.position, transform.rotation);
            attack.Play();
        }    
    }
}
