using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatCatch : MonoBehaviour
{
    [SerializeField] Transform spawnPos;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            col.gameObject.transform.position = spawnPos.position;
        }
    }
}

