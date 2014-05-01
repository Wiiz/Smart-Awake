using UnityEngine;

public class CheckLetters : MonoBehaviour
{
	void OnGUI () { 
		
		GUI.depth = 2; 
		
		if (Event.current.type == EventType.MouseDown) { 
			// Explosion!
			CloudEffect.Instance.Explosion(transform.position);
			// Destroy
			Destroy(gameObject);
		} 

	}
}