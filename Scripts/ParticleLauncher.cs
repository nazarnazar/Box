﻿using UnityEngine;
using System.Collections;

public class ParticleLauncher : MonoBehaviour {

	public ParticleSystem particleLauncher;
	public int startEmit = 100;
	bool touched;

	ParticleSystem.Particle[] particles;
	int count;

	float velX, velY, velZ;


	// Use this for initialization
	void Start () {
		particleLauncher.startLifetime = float.PositiveInfinity;
		particleLauncher.Emit (startEmit);
	}
	
	// Update is called once per frame
	void Update () {

		if (!touched) {
			particles = new ParticleSystem.Particle[particleLauncher.particleCount];
			count = particleLauncher.GetParticles (particles);

			for (int i = 0; i < count; i++) {
				particles [i].velocity = new Vector3 (velX, velY, velZ);
			}

			particleLauncher.SetParticles (particles, count); 
		}

	}

	void OnParticleCollision(GameObject other) {
		if (other.tag == "Ball" && ! touched) {
			touched = true;
			particleLauncher.gravityModifier = 0.5f;
			// CubeSpawner cs = FindObjectOfType<CubeSpawner> ();
			// cs.Respawn ();

			Destroy (GameObject.FindGameObjectWithTag("Steam"));
		}
	}

	public void SetVelocity(float x, float y, float z) {
		velX = x;
		velY = y;
		velZ = z;
	}
}
