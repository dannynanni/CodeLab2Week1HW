using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float move;
	Vector3 pos;

	// Use this for initialization
	void Start () {

		pos = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey (KeyCode.W)) {
			Debug.Log ("W");
			pos.y += move;
		}

		if (Input.GetKey (KeyCode.S)) {

			pos.y -= move;
		}

		if (Input.GetKey (KeyCode.A)) {

			pos.x -= move;
		}

		if (Input.GetKey (KeyCode.D)) {

			pos.x += move;
		}

		transform.position = pos;
	}

}
