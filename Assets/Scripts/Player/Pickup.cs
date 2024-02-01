using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    int cheese;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100f))
            {
                if (hit.transform.gameObject.tag == "Cheese")
                {
                    Destroy(hit.transform.gameObject);
                    cheese++;
                }
            }
        }
    }
}
