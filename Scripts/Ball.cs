using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Gradient grad;


	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = grad.Evaluate (Random.Range (0f, 1f));

		GvrAudioSource [] gvrAudio = GetComponents<GvrAudioSource> ();
		gvrAudio[0].Play ();
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.tag == "NextOne" || col.gameObject.tag == "GoMenu") {
			GvrAudioSource [] gvrAudio = GetComponents<GvrAudioSource> ();
			gvrAudio[1].Play ();
		}
	}
}
