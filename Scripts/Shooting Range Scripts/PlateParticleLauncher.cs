using UnityEngine;
using System.Collections;

public class PlateParticleLauncher : MonoBehaviour {

	public ParticleSystem particleLauncher;
	public int startEmit = 100;
	bool touched;

	ParticleSystem.Particle[] particles;
	int count;

	float velX, velY, velZ;

	Color startColor = new Color(1f, 0.4f, 0);


	// Use this for initialization
	void Start () {
		particleLauncher.startColor = startColor;
		particleLauncher.startLifetime = float.PositiveInfinity;
		particleLauncher.Emit (startEmit);

		particles = new ParticleSystem.Particle[particleLauncher.particleCount];
		count = particleLauncher.GetParticles (particles);

		for (int i = 0; i < count; i++) {
			particles [i].velocity = new Vector3 (velX, velY, velZ);
		}

		particleLauncher.SetParticles (particles, count); 

		GvrAudioSource [] gvrAudio = GetComponents<GvrAudioSource> ();
		gvrAudio[1].Play ();
	}

	void OnParticleCollision(GameObject other) {
		if (other.tag == "Ball" && ! touched) {
			touched = true;
			particleLauncher.gravityModifier = 1f;

			GameplayController gc = FindObjectOfType<GameplayController> ();
			BallSpawner bs = FindObjectOfType<BallSpawner> ();

			if (startColor == new Color (1f, 0.2f, 0f)) {
				bs.IncreaseFireRate ();
				gc.IncScore ();
			} else if (startColor == new Color (0.4f, 1f, 0f)) {
				gc.IncScore (2, 10);
			} else if (startColor == new Color (0.8f, 0f, 1f)) {
				bs.IncreaseBallSpeed ();
				gc.IncScore ();
			} else {
				gc.IncScore ();
			}

			GvrAudioSource [] gvrAudio = GetComponents<GvrAudioSource> ();
			gvrAudio[0].Play ();
		}
	}

	public void SetVelocity(float x, float y, float z) {
		velX = x;
		velY = y;
		velZ = z;
	}

	public void SetStartColor(Color color)
	{
		startColor = color;
	}
}
