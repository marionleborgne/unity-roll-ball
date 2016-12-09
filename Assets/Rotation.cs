using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// detal time is the time in s between frames (<1)
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
