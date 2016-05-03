using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class wallyell : MonoBehaviour {

	private int score;
	public Text scoreText;
	void Start () {
		score = 0;
		scoreText .text = "Score :" + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider bull)
	{
		if (bull.gameObject.CompareTag ("bull")) {
			Destroy(bull.gameObject);
			Destroy(this.gameObject);
			score=score+1;
			scoreText .text ="Score :"+score .ToString();
		}

	}
}
