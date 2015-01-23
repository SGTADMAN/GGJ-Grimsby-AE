using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float Speed;
	private bool enter = false;
	// Use this for initialization
	void Start () {
	}

	void OnMouseDown()
	{
		transform.position = new Vector3 (transform.position.x + Speed, transform.position.y, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
