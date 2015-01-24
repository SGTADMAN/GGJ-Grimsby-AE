using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	Move m;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	void OnMouseDown()
	{
		m.Jump ();
	}
	// Update is called once per frame
	void Update () {
	}
}
