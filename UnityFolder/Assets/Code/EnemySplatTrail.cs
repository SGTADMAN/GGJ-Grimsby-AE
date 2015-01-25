using UnityEngine;
using System.Collections;

public class EnemySplatTrail : MonoBehaviour {

	public GameObject splat;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float Y = Random.Range (-0.5f, 0.5f);
		GameObject.Instantiate (splat, new Vector3 (gameObject.transform.position.x, 
		                                            gameObject.transform.position.y + Y,
		                                            0), Quaternion.identity);
	}
}
