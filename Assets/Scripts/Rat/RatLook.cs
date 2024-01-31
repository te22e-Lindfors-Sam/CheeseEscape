using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatLook : MonoBehaviour
{
    public Transform target;
    public Transform child;

    void Update()
    {
        child.right = transform.forward;
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(this.transform.position, transform.forward * 10f);
    }
}
