using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.LeftArrow)) {
		
			transform.RotateAround(player.transform.position, Vector3.up, 300 * Time.deltaTime);
		}
	
		if (Input.GetKey (KeyCode.RightArrow)) {

			transform.RotateAround(player.transform.position, Vector3.up, -300 * Time.deltaTime);
		}
		}
}
