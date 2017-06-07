using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultController : MonoBehaviour {

	// Text boxText;
	Text rangeText;

	// int boxBest;
	int rangeBest;

	// Use this for initialization
	void Start () {
		// boxText = GameObject.FindGameObjectWithTag ("TextBox").GetComponent<Text> ();
		rangeText = GameObject.FindGameObjectWithTag ("TextRange").GetComponent<Text> ();

		/* if (PlayerPrefs.HasKey ("boxBest")) {
			boxBest = PlayerPrefs.GetInt ("boxBest");
		} else {
			PlayerPrefs.SetInt ("boxBest", 0);
		} */
		if (PlayerPrefs.HasKey ("rangeBest")) {
			rangeBest = PlayerPrefs.GetInt ("rangeBest");
		} else {
			PlayerPrefs.SetInt ("rangeBest", 0);
		}

		// boxText.text = "Best: " + boxBest.ToString ();
		rangeText.text = "Best: " + rangeBest.ToString ();
	}
}
