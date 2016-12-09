using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	Vector3 distance;

	// Use this for initialization
	void Start () {
		// camera player offset
		distance = transform.position - player.transform.position;
	}
	
	// Not regular update. It's an update after everything is update.
	// I.e: Update the camera after you know the position of the player
	void LateUpdate () {
		// preserve the offset of the camera-player when the player moves.
		transform.position = player.transform.position + distance;
	}
}
