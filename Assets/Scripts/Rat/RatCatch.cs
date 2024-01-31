using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCatch : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("tell me");
        }
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.gameObject.name);
    }
}
