using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool _isInsideTrigger = false;
    public Animator _animator;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;
            _animator.SetBool("open", false);
        }
    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _animator.SetBool("open", true);
        }
    }
}
