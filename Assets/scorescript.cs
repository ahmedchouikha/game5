using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
	public Text scoreText;
	public int lettuceValue;
	public int wormValue;
	private int point;
	// Use this for initialization
	void Start()
	{
		point = 0;
		SetCountText();
	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("enemy"))
		{
			Destroy(other.gameObject);
			point += wormValue;
			SetCountText();
		}
		else if (other.gameObject.CompareTag("enemy"))
		{
			Destroy(other.gameObject);
			point += lettuceValue;
			SetCountText();
		}
	}
	void SetCountText()
	{
		scoreText.text = "score:" + point.ToString();
	}
}
