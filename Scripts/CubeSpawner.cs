using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	public GameObject cube;
	GameObject instance;

	// Use this for initialization
	void Start () {
		instance = Instantiate (cube);
		instance.transform.position = new Vector3(0, 0, 0);
	}

	public void Respawn() {
		instance = Instantiate (cube);
		instance.transform.position = new Vector3(0, 0, 0);
		// instance.transform.position = new Vector3(Random.Range(-12f, 12f), Random.Range(0f, 12f), Random.Range(0f, 12f));
	}
}
