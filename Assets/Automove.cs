using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;
using DG.Tweening;

public class Automove : MonoBehaviour
{


    public Vector3 movimiento;
    public float speedrock;


    void Update()
    {
        this.transform.localPosition = new Vector3(Mathf.PingPong(Time.time * speedrock, movimiento.x), Mathf.PingPong(Time.time * speedrock, movimiento.y), Mathf.PingPong(Time.time * speedrock, movimiento.z));
    }
}
