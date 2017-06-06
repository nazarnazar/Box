using UnityEngine;
using System.Collections;

public class AudioObject : MonoBehaviour {

	static bool live = false;

	void Awake() {
		DontDestroyOnLoad (transform.gameObject);
	}
}
