using UnityEngine;
using System.Collections;

public class SplatTrail : MonoBehaviour {
	public GameObject splat;
	private Move m;
	// Use this for initialization
	void Start () {
		m = gameObject.GetComponent<Move> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!m.NotMoving) {
			float Y = Random.Range (-1.0f, 1.0f);
			GameObject.Instantiate (splat, new Vector3 (gameObject.transform.position.x, 
                                    gameObject.transform.position.y + Y,
                                    0), Quaternion.identity);
			}
	}
}
