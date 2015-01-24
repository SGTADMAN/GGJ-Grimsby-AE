#pragma strict

public var  maxSpeed: float = 10f;
public var moveSpeed: int = 5;
private var  facingRight: boolean = true; 
 
function Start () {

}

function Update () {

   var move:float = Input.GetAxis ("Horizontal");

	rigidbody2D.velocity = new Vector2(move * maxSpeed, rigidbody2D.velocity.y);
   
  // anim.SetFloat("speed", Mathf.Abs(move));
   
   	if (move > 0 && !facingRight) {
	flip();}
	else if (move< 0 && facingRight) {
	flip();
	}
   
}

function flip() {
	facingRight = !facingRight;
	var theScale:Vector3  = transform.localScale;
	theScale.x *= -1;
	transform.localScale = theScale;

}