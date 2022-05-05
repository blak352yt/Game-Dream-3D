using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    public RaycastHit hit;
    private bool activateLever = false;
    public Camera mainCamera;

    void Update()
    {
        Vector3 fwd = mainCamera.transform.TransformDirection(Vector3.forward);
        // draw Ray in scene view 
        Debug.DrawRay(mainCamera.transform.position, fwd * 2, Color.green);
        if (Physics.Raycast(mainCamera.transform.position, fwd, out hit))
        {
            // distance to gameobject
            if (hit.distance <= 7.0f)
            {
                // check tag
                if (hit.collider.gameObject.tag == "lever" && Input.GetKeyDown("e"))
                {
                    activateLever = !activateLever;
                }
            }
        }
    }
}
