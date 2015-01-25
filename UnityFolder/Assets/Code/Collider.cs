using UnityEngine;
using System.Collections;
using System.Threading;

public class Collider : MonoBehaviour {
	bool animation;
	public Animator anim;
	bool finish = false;
	GameObject g;
	// Use this for initialization
	void Start () {
		g = GameObject.Find("grad");
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player") {
			animation = true;
			GameObject.Destroy(GameObject.Find("Butterfly"));
			Move m = GameObject.Find("Player").GetComponent<Move>();
			m.ZeroSpeed();
			Move.END = true;
			finish = true;
		}
	}
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(7);
	}
	// Update is called once per frame
	void Update () {
		anim.SetBool ("death", animation);
		if (finish) {

			//Thread.Sleep(5000);
				g.transform.position = new Vector3 (g.transform.position.x - 0.25f, g.transform.position.y, 0);
				}
	}
}
