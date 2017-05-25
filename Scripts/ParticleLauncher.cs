using UnityEngine;
using System.Collections;

public class ParticleLauncher : MonoBehaviour {

	public ParticleSystem particleLauncher;
	public int startEmit = 100;
	bool touched;

	ParticleSystem.Particle[] particles;
	int count;


	// Use this for initialization
	void Start () {
		particleLauncher.startLifetime = float.PositiveInfinity;
		particleLauncher.Emit (startEmit);
	}
	
	// Update is called once per frame
	void Update () {

		particles = new ParticleSystem.Particle[particleLauncher.particleCount];
		count = particleLauncher.GetParticles (particles);

		for (int i = 0; i < count; i++) {
			particles [i].velocity = new Vector3 (0, 1, 0);
		}

		particleLauncher.SetParticles (particles, count);
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
