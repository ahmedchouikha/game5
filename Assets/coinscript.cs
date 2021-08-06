using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour
{
	public GameObject PlayerPrefab;
	// Use this for initialization


	void OnCollisionEnter(Collision other)
	{

		if (other.transform.tag == "player")
		{
			Destroy(gameObject);
		}
	}



}