using UnityEngine;
using System.Collections;

public class MoveAnimal : MonoBehaviour {
	public float Distance;
	public float Speed;
	private float lastPos = 0;
	private float totalpos = 0;
	private float f = 0;
	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
	}
	
	// Update is called once per frame
	void Update () {
		if(lastPos != 0)
			f = Mathf.Abs(gameObject.transform.position.x - lastPos);
		totalpos += f;
		if (Distance < Mathf.Abs (totalpos)) {
			Vector3 theScale = transform.localScale;
			//if (theScale.x > 0)
				theScale.x *= -1;
			transform.localScale = theScale;
			if (Speed > 0) {
				Speed = -Speed;
			} else {
				Speed = -Speed;
			}
			rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
			totalpos = 0;
		} else {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y);
		}
		lastPos = gameObject.transform.position.x;
	}
}
