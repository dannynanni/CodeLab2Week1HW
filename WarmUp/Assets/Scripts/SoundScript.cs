using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {

	AudioSource bump;
	// Use this for initialization
	void Start () {
	
		bump = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision collision) {

		if (collision.relativeVelocity.magnitude > 2)
			bump.Play(); 
	}
}
