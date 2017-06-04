using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	bool spawned;

	// Use this for initialization
	void Start () {
		spawned = false;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Ball" && ! spawned) {
			CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
			cs.Respawn ();
			spawned = true;
		}
	}
}
