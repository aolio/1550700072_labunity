using UnityEngine;
using System.Collections;

public class wallred : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider bull)
	{
		if (bull.gameObject.CompareTag ("bull")) {
			Destroy(bull.gameObject);

		}
	}
}
