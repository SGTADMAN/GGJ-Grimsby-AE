using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float Speed;
	public float JumpPower;
	private Vector3 position;
	private bool facingright = true;
	public static bool OnTheGround = true;
	public Animator anim;
	private bool CanAttack = false;
	// Use this for initialization
	void Start () {
	}
	public void MoveRight()
	{
		if (!CanAttack) {
			Vector3 theScale = transform.localScale;
			if (theScale.x < 0)
					theScale.x *= -1;
			transform.localScale = theScale;
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x + Speed, rigidbody2D.velocity.y);
		}
	}
	public void MoveLeft()
	{
		if (!CanAttack) {
			Vector3 theScale = transform.localScale;
			if (theScale.x > 0)
					theScale.x *= -1;
			transform.localScale = theScale;
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x - Speed, rigidbody2D.velocity.y);
		}
	}
	public void Jump()
	{
		if (OnTheGround) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y + JumpPower);
			OnTheGround = false;
		}
	}
	public void Fire()
	{
		if (OnTheGround) {
			CanAttack = true;
		}
	}
	public void CantAttack()
	{
		CanAttack = false;
	}
	public void ZeroSpeed()
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
	}
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("speed", Mathf.Abs(rigidbody2D.velocity.x));
		anim.SetBool ("jump", OnTheGround);
		anim.SetBool ("attack", CanAttack);
	}
}
