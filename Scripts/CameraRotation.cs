using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {

	public float speed;
	float xRotation, yRotation;
	Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponentInChildren<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		xRotation = Input.GetAxis ("Mouse X") * speed;
		yRotation = Input.GetAxis ("Mouse Y") * speed;
		transform.rotation = Quaternion.Euler (0, xRotation, 0) * transform.rotation;
		camera.transform.localRotation = Quaternion.Euler (-yRotation, 0, 0) * camera.transform.localRotation;
	}
}
