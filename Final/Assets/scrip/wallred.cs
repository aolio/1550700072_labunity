using UnityEngine;
using System.Collections;

public class wallred : MonoBehaviour {
	public int speed;
	private Vector3 startPoint;

	// Use this for initialization
	void Start () {
		speed = 3;
		startPoint = transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		MoveVertical ();
	}
	void MoveVertical()
	{
		transform.position = new Vector3(transform.position.x, startPoint.y + Mathf.Sin(Time.time * speed), transform.position.z);
		
		if(transform.position.y > 1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
		else if(transform.position.y < -1.0f)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		}
	}

	void OnTriggerEnter(Collider bull)
	{
		if (bull.gameObject.CompareTag ("bull")) {
			Destroy(bull.gameObject);

		}
	}
}
