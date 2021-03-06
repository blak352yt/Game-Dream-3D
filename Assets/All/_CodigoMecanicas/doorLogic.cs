using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class doorLogic : MonoBehaviour
{
    public GameObject puerta;
    public GameObject palanca;
    //abrir puerta
    public float speed;
    public float distance;

    //Cerrar la puerta
    public float distanceCerrado;
    public Vector3 rotationCerrado;

    public Vector3 rotation;
    public float speedlevel;

    public bool puertaAbierta;

    public GameObject player;

    bool Cerca;

    public AudioSource PlaySound;






    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            if (Keyboard.current.xKey.wasPressedThisFrame && puertaAbierta == false)
            {
                abrirpuerta();
            }
            if (Keyboard.current.xKey.wasPressedThisFrame && puertaAbierta == true)
            {
                cerrarlapuerta();
            }

        }
        Cerca = true;
    }
    private void OnTriggerExit(Collider other)
    {
        Cerca = false;
    }



    public void abrirpuerta()
    {

        Debug.Log("Abrir puerta ");
        puerta.transform.DOLocalMoveY(distance, speed);
        palanca.transform.DOLocalRotate(rotation, speedlevel);
        PlaySound.Play();

        StartCoroutine(CoroutineAbierta());


    }

    public void cerrarlapuerta()
    {
        Debug.Log("cerrar puerta ");
        puerta.transform.DOLocalMoveY(distanceCerrado, speed);
        palanca.transform.DOLocalRotate(rotationCerrado, speedlevel);
        StartCoroutine(CoroutineCerrar());
        PlaySound.Play();

    }

    IEnumerator CoroutineAbierta()
    {
        //espera 0.5 segundos
        yield return new WaitForSeconds(1f);
        puertaAbierta = true;
    }

    IEnumerator CoroutineCerrar()
    {
        //espera 0.5 segundos
        yield return new WaitForSeconds(1f);
        puertaAbierta = false;
    }

    public void UIclick()
    {
        if (puertaAbierta == false && Cerca == true)
        {
            abrirpuerta();
        }
        else
        {
            if (puertaAbierta == true && Cerca == true)
            {
                cerrarlapuerta();
            }
        }
    }


}

