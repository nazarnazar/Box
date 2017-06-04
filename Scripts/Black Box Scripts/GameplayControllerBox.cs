using UnityEngine;
using System.Collections;

public class GameplayControllerBox : MonoBehaviour {
	float gameTimer = 60f;
	float gameTime;

	TextMesh timeText;
	TextMesh scoreText;

	float oneSecondTimer;
	int secondsLeft;
	int scored;


	// Use this for initialization
	void Start () {
		timeText = GameObject.FindGameObjectWithTag ("TextTime").GetComponent<TextMesh> ();
		secondsLeft = 60;
		timeText.text = "Time: " + secondsLeft.ToString (); 

		scoreText = GameObject.FindGameObjectWithTag ("TextScore").GetComponent<TextMesh> ();
		scored = 0;
		scoreText.text = "Score: " + scored.ToString ();

		gameTime = gameTimer;
	}

	// Update is called once per frame
	void Update () {
		gameTime -= Time.deltaTime;
		oneSecondTimer -= Time.deltaTime;
		if (gameTime <= 0) {
			CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
			cs.Spawn = false;
			if (scored > PlayerPrefs.GetInt ("boxBest")) {
				PlayerPrefs.SetInt ("boxBest", scored);
			}
		} else if (oneSecondTimer <= 0) {
			secondsLeft--;
			timeText.text = "Time: " + secondsLeft.ToString ();
			oneSecondTimer = 1f;
		}
	}

	public void IncScore() {
		scored++;
		scoreText.text = "Score: " + scored.ToString ();
	}
}
