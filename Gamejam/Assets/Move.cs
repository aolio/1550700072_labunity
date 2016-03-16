using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;
	
	private Rigidbody rb;
	
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(5,0,0);
	}
}
