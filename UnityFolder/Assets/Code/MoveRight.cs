using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour {
	Move m;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	void OnMouseDown()
	{
		m.MoveRight ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			m.ZeroSpeed();		
		}
	}
}
