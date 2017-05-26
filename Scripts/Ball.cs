using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Gradient grad;


	// Use this for initialization
	void Start () {
		GetComponent<Renderer> ().material.color = grad.Evaluate (Random.Range (0f, 1f));
	}
}
