﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour 
{
	private Rigidbody rb;
	
	public float speed;
	public float tilt;
	public Boundary boundary;

	public GameObject shot;
	public GameObject shotSpawn; 
	public float fireRate;

	private float nextFire;
	
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire) 
		{
			shot = Instantiate(shot) as GameObject;
			nextFire = Time.time + fireRate;
			//GameObject clone = 
			shot.transform.position = shotSpawn.transform.position;

		}
	}
		
	void FixedUpdate() 
	{
		float mH = Input.GetAxis ("Horizontal");  
		float mV = Input.GetAxis ("Vertical"); 
		
		Vector3 movment = new Vector3 (mH, 0.0F, mV);
		rb.velocity = movment * speed;
		
		rb.position = new Vector3 
			(
				Mathf.Clamp (rb.position.x, boundary.xMin, boundary.xMax),
				0.0F,
				Mathf.Clamp (rb.position.z, boundary.zMin, boundary.zMax)
				);
		
		rb.rotation = Quaternion.Euler (0.0F, 0.0f, rb.velocity.x * -tilt);
	} 
	
}﻿