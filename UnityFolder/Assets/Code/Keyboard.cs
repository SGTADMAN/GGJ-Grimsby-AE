using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour {
	Move m;
	bool right = false;
	bool left = false;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			m.MoveRight ();	
			right = true;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			m.MoveLeft ();
			left = true;		
		}
		if (right) {
			if (Input.GetKeyUp (KeyCode.D)) {
				right = false;
				m.ZeroSpeed();
			}
		}
		if (left) {
			if (Input.GetKeyUp (KeyCode.A)) {
				left = false;
				m.ZeroSpeed();
			}
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			m.Jump();
		}
	}
}
