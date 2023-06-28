using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(name + " triggered " + collision.name);
        Camera.main.GetComponent<TimeReload>().Invoke();
    }
}
