﻿using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour {
	Move m;
	bool buttondown = false;
	// Use this for initialization
	void Start () {
		m = GameObject.Find ("Player").GetComponent<Move> ();
	}
	void OnMouseDown()
	{
		m.MoveRight ();
		buttondown = true;
	}
	// Update is called once per frame
	void Update () {
		if (buttondown) {
			if (Input.GetMouseButtonUp (0)) {
				m.ZeroSpeed ();	
				buttondown = false;
			}
		}
	}
}
