using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.right*2;
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
