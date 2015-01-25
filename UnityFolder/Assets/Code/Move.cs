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
	public GameObject redAttack;
	public float AttackTimer;
	private float timer;
	public GameObject Red;
	public GameObject Green;
	public GameObject Purple;
	public GameObject Blue;
	// Use this for initialization
	void Start () {
		timer = AttackTimer;
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
			int num = Random.Range(0, 3);
			switch (num) {
			case 0:
				GameObject.Instantiate(Red, gameObject.transform.position, Quaternion.identity);
				break;
			case 1:
				GameObject.Instantiate(Green, gameObject.transform.position, Quaternion.identity);
				break;
			case 2:
				GameObject.Instantiate(Purple, gameObject.transform.position, Quaternion.identity);
				break;
			case 3:
				GameObject.Instantiate(Blue, gameObject.transform.position, Quaternion.identity);
				break;
			}
			/*GameObject.Instantiate(redAttack, new Vector3(gameObject.transform.position.x,
			                                              gameObject.transform.position.y - 0.13f,
			                                              0),
			                       						  Quaternion.identity);*/
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
		if (AttackTimer > 0)
			AttackTimer -= Time.deltaTime;
		if (AttackTimer <= 0) {
			GameObject.Destroy (GameObject.Find ("RedAttack(Clone)"));
			//GameObject.Instantiate(Paint, gameObject.transform.position, Quaternion.identity);
			//Paint p = GameObject.Find("Fire(Clone").GetComponent<Paint>();
			//p.Red();

			AttackTimer = timer;
		}
	}
}
