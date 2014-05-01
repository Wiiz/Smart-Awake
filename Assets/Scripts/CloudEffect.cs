using UnityEngine;

public class CloudEffect : MonoBehaviour
{
	public static CloudEffect Instance;
	
	public ParticleSystem smokeEffect;
	
	void Awake()
	{
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of CloudEffect!");
		}
		
		Instance = this;
	}

	/// Create an explosion at the given location
	public void Explosion(Vector3 position)
	{
		// Smoke
		instantiate(smokeEffect, position);
	}

	/// Instantiate a Particle system from prefab
	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(
			prefab,
			position,
			Quaternion.identity
			) as ParticleSystem;
		
		// Make sure it will be destroyed
		Destroy(
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
			);
		
		return newParticleSystem;
	}
}