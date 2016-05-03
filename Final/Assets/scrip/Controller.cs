using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	public float speed;


	void Start () {
		GetComponent<Rigidbody> ().velocity = transform.right * speed;
	

	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
