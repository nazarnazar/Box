using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level) {
		SceneManager.LoadScene (level);

		GvrAudioSource gvrAudio = GetComponent<GvrAudioSource> ();
		gvrAudio.Play ();
	}
}
