using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float move;
	Vector3 pos;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

		pos = transform.position;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("W");
			rb.AddForce(transform.forward * move);
		}

		if (Input.GetKey (KeyCode.S)) {

			rb.AddForce (transform.forward * -move);
		}

		if (Input.GetKey (KeyCode.A)) {

			pos.x -= move;
		}

		if (Input.GetKey (KeyCode.D)) {

			pos.x += move;
		}
	}

}
