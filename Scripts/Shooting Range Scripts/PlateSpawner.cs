using UnityEngine;
using System.Collections;

public class PlateSpawner : MonoBehaviour {

	public GameObject plate;
	GameObject instance;

	public float timer = 5f;
	float time;

	Vector3[] PlateVelocityArray = new [] {
		new Vector3 (0, 5, 20), new Vector3 (-15, 5, 15),
		new Vector3 (15, 10, 0), new Vector3 (10, 10, -20)
	};

	Vector3[] PlatePosArray = new [] {
		new Vector3 (0, 10, -40), new Vector3 (45, 15, -25),
		new Vector3 (-50, -5, 20), new Vector3 (-30, -5, 100)
	};

	int indexCounter;

	public bool Spawn { get; set; }

	// Use this for initialization
	void Start () {
		time = timer;
		indexCounter = 0;
		Spawn = true;
	}

	void Update() {
		time -= Time.deltaTime;

		if (time <= 0 && Spawn) {
			SpawnPlate (indexCounter);
		}
	}

	void SpawnPlate(int index) {
		instance = Instantiate (plate);
		instance.transform.position = PlatePosArray [index];

		PlateParticleLauncher ppl = FindObjectOfType<PlateParticleLauncher> ();
		ppl.SetVelocity (PlateVelocityArray [indexCounter].x, PlateVelocityArray [indexCounter].y, PlateVelocityArray [indexCounter].z);

		time = timer;

		indexCounter++;
		if (indexCounter == 4) {
			indexCounter = 0;
		}
	}
}
