using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWaves : MonoBehaviour
{
    [SerializeField] float timeBeforeStart = 1, timeInterval = 0.1f;
    [SerializeField] int repeat = 10;
    [SerializeField] GameObject spawnPrefab = null;
    [SerializeField]

    void Start()
    {
        InvokeRepeating("SpawnWaveUnit", timeBeforeStart, timeInterval);
    }

    void SpawnWaveUnit()
    {
        if (repeat > 0)
        {
            repeat --;
        }
        Instantiate(spawnPrefab, transform.position, transform.rotation);
        if (repeat == 0)
        {
            CancelInvoke();
        }
    }
}
