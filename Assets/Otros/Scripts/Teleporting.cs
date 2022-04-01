using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporting : MonoBehaviour
{

	public Transform TeleportTarget;
	public GameObject Player;

	void OnTriggerEnter (Collider Other)
	{
		Player.transform.position = TeleportTarget.transform.position;


	}


}
