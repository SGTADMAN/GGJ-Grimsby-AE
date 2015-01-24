using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float Speed;
	private Vector3 position;
	private bool facingright = true;
	// Use this for initialization
	void Start () {
	}
	public void MoveRight()
	{
		Vector3 theScale = transform.localScale;
		if(theScale.x < 0)
			theScale.x *= -1;
		transform.localScale = theScale;
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
	}
	public void MoveLeft()
	{
		Vector3 theScale = transform.localScale;
		if(theScale.x > 0)
			theScale.x *= -1;
		transform.localScale = theScale;
		rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x - Speed, rigidbody2D.velocity.y);
	}
	public void ZeroSpeed()
	{
		rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
	}
	// Update is called once per frame
	void Update () {
	}
}
