using UnityEngine;
using System.Collections;

public class PaintBallMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x +10, rigidbody2D.velocity.y);
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Wolf") {
			GameObject.Destroy (gameObject);
			GameObject.Destroy(other.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y);
	}
}
