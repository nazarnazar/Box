using UnityEngine;
using System.Collections;

public class ParticleLauncher : MonoBehaviour {

	public ParticleSystem particleLauncher;
	public int startEmit = 100;
	bool touched;

	public float speed = 1f;
	public float xLimit = 13f;
	float xPos;
	bool goRight = false;


	// Use this for initialization
	void Start () {
		/* if (Random.Range (0, 2) == 1) {
			transform.Rotate (0, 180f, 0);
		} */
		particleLauncher.startLifetime = float.PositiveInfinity;
		particleLauncher.Emit (startEmit);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < xLimit && goRight) {
			xPos = transform.position.x + Time.deltaTime * speed;
		} else if (transform.position.x > xLimit && goRight) {
			goRight = false;
		} else if (transform.position.x > -xLimit && !goRight) {
			xPos = transform.position.x - Time.deltaTime * speed;
		} else if (transform.position.x < -xLimit && !goRight) {
			goRight = true;
		} else {}

		transform.position = new Vector3 (xPos, transform.position.y, transform.position.z);
	}

	void OnParticleCollision(GameObject other) {
		if (other.tag == "Ball" && ! touched) {
			touched = true;
			//particleLauncher.gravityModifier = 0.1f;
			CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
			//cs.Respawn ();
		}
	}
}
