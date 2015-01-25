#pragma strict
public var changeScene : boolean = false;
public var Audio : AudioClip;
public var Dragon_anim : Animation;

function Start () {
if (changeScene == false) {
						Debug.LogError ("change scene is false");
						yield WaitForSeconds (7);
						changeScene = true;
						}
	animation.Play("Dragon_anim");
		
		yield WaitForSeconds (animation["Dragon_anim"].length);
			animation.Play("Vicen_anim");
				yield WaitForSeconds (animation["Vicen_anim"].length);
					audio.PlayOneShot(Audio, 0.7);
						

}

function Update () {
if (changeScene) {
Debug.LogError ("change scene = true");
	Application.LoadLevel ("TheGame");
}
}