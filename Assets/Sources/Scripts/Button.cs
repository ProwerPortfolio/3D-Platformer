﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour 
{
	[SerializeField]
	private UnityEvent OnClick = null;

	void Awake()	 
	{
		GetComponent<Animator>().enabled = false;
	}

	void OnTriggerEnter(Collider col)
	{

		if(col.CompareTag("Player") == true)
		{
			OnClick.Invoke();
			GetComponent<Animator>().enabled = true;
		}
	}

}
