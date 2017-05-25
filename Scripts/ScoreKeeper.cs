using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	int score;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void Increment(int d) {
		score += d;
		print ("Score:" + score);
	}
}
