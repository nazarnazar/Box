using UnityEngine;
using System.Collections;

public class BoxHolder : MonoBehaviour {

	public float speedK;

	public float xMinLim, xMaxLim;
	public float yMinLim, yMaxLim;
	public float zMinLim, zMaxLim;

	float nextX, nextY, nextZ;
	float prevX, prevY, prevZ;
	float diffX, diffY, diffZ;

	ParticleLauncher pl;

	Rigidbody rb;

	bool goRightX;


	// Use this for initialization
	void Start () {
		pl = GetComponentInChildren<ParticleLauncher> ();

		rb = GetComponent<Rigidbody> ();

		CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
		cs.GetRandomPosXYZ (out nextX, out nextY, out nextZ);
	}
	
	// Update is called once per frame
	void Update () {
		
		rb.velocity = new Vector3 (diffX, diffY, diffZ);

		if (goRightX && transform.position.x >= nextX) {
			SetNextPoint ();
		} else if (!goRightX && transform.position.x <= nextX) {
			SetNextPoint ();
		} else {}
	}

	void SetNextPoint() {
		prevX = nextX;
		prevY = nextY;
		prevZ = nextZ;

		nextX = Random.Range (xMinLim, xMaxLim);
		nextY = Random.Range (yMinLim, yMaxLim);
		nextZ = Random.Range (zMinLim, zMaxLim);

		if (nextX > prevX) {
			goRightX = true;
		} else {
			goRightX = false;
		}

		diffX = (nextX - prevX) / speedK;
		diffY = (nextY - prevY) / speedK;
		diffZ = (nextZ - prevZ) / speedK;

		pl.SetVelocity (diffX, diffY, diffZ);
	}
}
