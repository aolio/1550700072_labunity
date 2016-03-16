using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
	public float tumble;
	
	void Start ()
	{
		Rigidbody rb;
		rb = GetComponent<Rigidtybody> ();
		rb.angularVelocity = Random.insideUnitSphere * tumble;
	}
}
