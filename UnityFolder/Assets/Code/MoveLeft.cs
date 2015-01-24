using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {
	Move m;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	void OnMouseDown()
	{
		m.MoveLeft ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			m.ZeroSpeed();		
		}
	}
}
