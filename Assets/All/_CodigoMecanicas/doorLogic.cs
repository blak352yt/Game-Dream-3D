using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
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



	private void OnTriggerStay(Collider other)
	{
		listoparausar();


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




		}

	public void insusable() { 
	}



}


