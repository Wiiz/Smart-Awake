using UnityEngine;
using System.Collections;

public class SoundEffect : MonoBehaviour
{
	public static SoundEffect Instance;
	
	public AudioClip boopSound;
	
	void Awake()
	{
		// Register the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffect!");
		}
		Instance = this;
	}
	
	public void MakeBoopSound()
	{
		MakeSound(boopSound);
	}

	private void MakeSound(AudioClip originalClip)
	{
		// As it is not 3D audio clip, position doesn't matter.
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}