using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	bool mover = false;
	Move m;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	//oid OnMouseDown()
	//{
	//	m.Jump ();
	//}
	// Update is called once per frame
	void Update () {
			if(Input.GetMouseButtonDown(0))
			{
				m.Jump();
			}
	}
}
