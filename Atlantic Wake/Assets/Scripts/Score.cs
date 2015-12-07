using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Text scoreText;
	public int fishValue;
	private int score;

	void Start() {
		score = 0;
		scoreText.text = "Score: " + score;
	}

	void OnTriggerEnter2D() {
		score += fishValue;
		scoreText.text = "Score: " + score;
	}

	void Update() {

	}

}