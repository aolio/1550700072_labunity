﻿using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	public float speed;
	private  Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		
	}
	
	public void up ()
	{
		
		rb.velocity = (Vector3.up * speed);
		
	}
}
