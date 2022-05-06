using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;
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

    bool Cerca;


    


	private void OnTriggerStay(Collider other)
	{
		listoparausar();

<<<<<<< HEAD
        }
        Cerca = true;
    }
=======

	}


	public void listoparausar()
	{
		if (Keyboard.current.eKey.wasPressedThisFrame && puertaAbierta == false)
		{
			Debug.Log("Abrir puerta ");
			puerta.transform.DOLocalMoveY(distance, speed);
			palanca.transform.DOLocalRotate(rotation, speedlevel);
			puertaAbierta = true;



		}
		else
		{
			//Cerrar la puerta
			if (Keyboard.current.eKey.wasPressedThisFrame && puertaAbierta == true)
			{
				Debug.Log("cerrar puerta ");
				puerta.transform.DOLocalMoveY(distanceCerrado, speed);
				palanca.transform.DOLocalRotate(rotationCerrado, speedlevel);
				puertaAbierta = false;

			}
		}
>>>>>>> 850361b851969d086bbce8d96e1bfadfd36b558c

	private void OnTriggerExit(Collider other)
	{
        Cerca = false;
	}



<<<<<<< HEAD
	public void abrirpuerta()
    {
=======
		}
>>>>>>> 850361b851969d086bbce8d96e1bfadfd36b558c

	public void insusable() { 
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


<<<<<<< HEAD

=======
>>>>>>> 850361b851969d086bbce8d96e1bfadfd36b558c
