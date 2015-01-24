using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {
	public static bool Arrived = false;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "player") {
			GameObject.Destroy (gameObject);
			PlayerControl.clicked = false;
			Arrived = true;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
