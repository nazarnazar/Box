using UnityEngine;
using System.Collections;

public class TouchDetection : MonoBehaviour {

	//public int damage = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		//ScoreKeeper sk = FindObjectOfType<ScoreKeeper> ();
		//sk.Increment (damage);
		if (col.gameObject.tag == "Ball") {
			Destroy (col.gameObject);
			CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
			cs.Respawn ();
		}
	}
}
