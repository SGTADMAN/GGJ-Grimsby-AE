using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public float Speed;
	public float JumpPower;
	private Vector3 position;
	public static bool OnTheGround = true;
	public Animator anim;
	private bool CanAttack = false;
	public bool NotMoving = true;
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
			NotMoving = false;
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
			NotMoving = false;
		}
	}
	public void Jump()
	{
		if (OnTheGround) {
			rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, rigidbody2D.velocity.y + JumpPower);
			OnTheGround = false;
			NotMoving = false;
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
		NotMoving = true;
		rigidbody2D.velocity = new Vector2 (0, 0);
	}
	// Update is called once per frame
	void Update () {
		if (rigidbody2D.velocity.x == 0 && rigidbody2D.velocity.y == 0)
			NotMoving = true;
		anim.SetFloat ("speed", Mathf.Abs(rigidbody2D.velocity.x));
		anim.SetBool ("jump", OnTheGround);
		anim.SetBool ("attack", CanAttack);
	}
}
