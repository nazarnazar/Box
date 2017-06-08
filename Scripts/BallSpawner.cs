using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public GameObject ball;
	public float speed;
	Camera cam;

	GvrReticle reticle;
	float r, g, b;
	public float fireRate = 1f;


	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera> ();
		reticle = FindObjectOfType<GvrReticle> ();

		r = 1f;
		g = 1f;
		b = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (new Color(r, g, b) == Color.white && Input.GetKeyDown (KeyCode.Mouse0)) {
			GameObject instance = Instantiate (ball);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = cam.transform.rotation * Vector3.forward * speed;
			g = 0.2f;
			b = 0;
			reticle.ChangeReticleColor (new Color(r, g, b));
		} else {
			if (g < 1f || b < 1f) {
				g += fireRate * Time.deltaTime;
				b += fireRate * Time.deltaTime;
			} else {
				g = 1f;
				b = 1f;
			}
			reticle.ChangeReticleColor (new Color(r, g, b));
		}
	}

	public void IncreaseFireRate()
	{
		fireRate += 0.5f;
	}

	public void IncreaseBallSpeed()
	{
		speed += 25f;
	}
}
