using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ball;
	public float speed;
	Camera cam;

	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject instance = Instantiate (ball);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = cam.transform.rotation * Vector3.forward * speed;
		}
	}
}
