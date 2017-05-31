using UnityEngine;
using System.Collections;

public class ResetSpawner : MonoBehaviour {

	public GameObject reset;

	public void SpawnReset()
	{
		Instantiate (reset);
	}
}
