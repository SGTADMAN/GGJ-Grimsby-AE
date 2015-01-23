using UnityEngine;
using System.Collections;

public class DetectCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider other) {
		GameObject.Destroy (gameObject);
		PlayerControl.clicked = false;
	}
	// Update is called once per frame
	void Update () {
	
	}
}
