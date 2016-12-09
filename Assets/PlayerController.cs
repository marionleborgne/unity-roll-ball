using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// add this when you use the UI
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Text scoreText;
	// This will add a param in the Unity UI (Inspector view of the player)
	public float speed = 100;

	Rigidbody body;
	int count;

	// Use this for initialization
	void Start () {
		// That the C#. It finds the right component with this type.
		// There is only one Rigibody because the script is attached to only one component.
		body = GetComponent<Rigidbody>();
		// Click on cmd + single quote to get help on rigibody and see its method and example code.
	}
	
	// Update is called once per frame. FixedUpdate is more reliable.
	void Update () {
		
	}

	// Anything that has Fixed in its name is linked to the physics engine
	void FixedUpdate() {
		// Horizontal and Vertical forces
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		// left handed coordinate system. 
		body.AddForce(new Vector3(h, 0, v) * speed);
	}

	// Collider trigger action
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Pickup")) {
			other.gameObject.SetActive(false); // set active hides the thing
			count++;
			string t = scoreText.text;
			int idx = t.IndexOf (':');
			scoreText.text = t.Substring (0, idx + 1) + count.ToString();
		}
	}
}
