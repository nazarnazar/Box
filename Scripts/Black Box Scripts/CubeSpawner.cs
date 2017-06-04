using UnityEngine;
using System.Collections;

public class CubeSpawner : MonoBehaviour {

	public GameObject cube;
	GameObject instance;

	float randomX, randomY, randomZ;

	public bool Spawn { get; set; }

	// Use this for initialization
	void Start () {
		instance = Instantiate (cube);
		instance.transform.position = new Vector3(1, 1, 1);

		randomX = randomY = randomZ = 1;

		Spawn = true;
	}

	public void Respawn() {
		if (Spawn) {
			instance = Instantiate (cube);
			// instance.transform.position = new Vector3(0, 0, 0);

			randomX = Random.Range (-10f, 10f);
			randomY = Random.Range (3f, 10f);
			randomZ = Random.Range (3f, 10f);
			instance.transform.position = new Vector3 (randomX, randomY, randomZ);
		}
	}

	public void GetRandomPosXYZ(out float x, out float y, out float z)
	{
		x = randomX;
		y = randomY;
		z = randomZ;
	}
}
