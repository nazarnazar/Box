using UnityEngine;
using System.Collections;

public class PlateSpawner : MonoBehaviour {

	public GameObject plate;
	GameObject instance;

	public float timer = 5f;
	float time;

	Vector3[] PlateVelocityArray = new [] {
		new Vector3 (0, 5, 20), new Vector3 (0, 6, 20),
		new Vector3 (-15, 5, 15), new Vector3 (15, 5, 15),
		new Vector3 (15, 10, 0), new Vector3 (-15, 10, 0),
		new Vector3 (10, 10, -20), new Vector3 (-10, 10, -20)
	};

	Vector3[] PlatePosArray = new [] {
		new Vector3 (0, 10, -40), new Vector3 (0, -0.75f, 4),
		new Vector3 (45, 15, -25), new Vector3 (-45, 15, -25),
		new Vector3 (-50, -5, 20), new Vector3 (50, -5, 20),
		new Vector3 (-30, -5, 100), new Vector3 (30, -5, 100)
	};

	int indexPlate;
	public float koef = 1f;

	public bool Spawn { get; set; }

	// Use this for initialization
	void Start () {
		time = timer;
		indexPlate = Random.Range (0, 8);
		Spawn = true;
	}

	void Update() {
		time -= Time.deltaTime;

		if (time <= 0 && Spawn) {
			SpawnPlate (indexPlate);
		}
	}

	void SpawnPlate(int index) {
		instance = Instantiate (plate);

		PlateParticleLauncher ppl = FindObjectOfType<PlateParticleLauncher> ();

		koef = Random.Range (0f, 10f);
		if (koef > 1f && koef < 2f) {
			koef = 1.25f;
			ppl.SetStartColor (new Color (1f, 0.2f, 0f));
		} else if (koef > 2f && koef < 3f) {
			koef = 1.25f;
			ppl.SetStartColor (new Color (0.4f, 1f, 0f));
		} else if (koef > 3f && koef < 4f) {
			koef = 1.25f;
			ppl.SetStartColor (new Color (0.8f, 0f, 1f));
		} else {
			ppl.SetStartColor (new Color (1f, 0.4f, 0));
			koef = 1f;
		}

		instance.transform.position = PlatePosArray [index];

		ppl.SetVelocity (PlateVelocityArray [index].x * koef, PlateVelocityArray [index].y * koef, PlateVelocityArray [index].z * koef);

		time = timer;

		indexPlate = Random.Range (0, 8);
	}
}
