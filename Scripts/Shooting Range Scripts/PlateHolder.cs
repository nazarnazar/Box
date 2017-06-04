using UnityEngine;
using System.Collections;

public class PlateHolder : MonoBehaviour {

	public float speedK;

	public float xMinLim, xMaxLim;
	public float yMinLim, yMaxLim;
	public float zMinLim, zMaxLim;

	float xVelocity, yVelocity, zVelocity;

	PlateParticleLauncher ppl;

	Rigidbody rb;


	// Use this for initialization
	void Start () {
		ppl = GetComponentInChildren<PlateParticleLauncher> ();
		rb = GetComponent<Rigidbody> ();

		SetNextVelocity ();
	}

	// Update is called once per frame
	void Update () {

	}

	void SetNextVelocity() {
		xVelocity = Random.Range (xMinLim, xMaxLim) * speedK;
		yVelocity = Random.Range (yMinLim, yMaxLim) * speedK;
		zVelocity = Random.Range (zMinLim, zMaxLim) * speedK;

		rb.velocity = new Vector3 (xVelocity, yVelocity, zVelocity);

		ppl.SetVelocity (xVelocity, yVelocity, zVelocity);
	}
}
