using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	public GameObject cube;
	Rigidbody rb;
	GameObject instance;
	public float timer = 10f;
	float time;

	// Use this for initialization
	void Start () {
		time = timer;
		//instance = Instantiate (cube);
		//instance.transform.position = new Vector3(0, 2f, 0);
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time < 0) {
			//Respawn ();
			time = timer;
		}
	}

	public void Respawn() {
		//rb = instance.GetComponent<Rigidbody> ();
		//rb.isKinematic = false;
		instance = Instantiate (cube);
		instance.transform.position = new Vector3(Random.Range(-6f, 6f), Random.Range(1f, 10f), Random.Range(0f, 6f));
		time = timer;
	}
}
