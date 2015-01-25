#pragma strict
public var MouseOverSprite : Sprite;
public var OriginalSprite : Sprite;
function Start () {

}
function OnMouseEnter()
{
	 GetComponent(SpriteRenderer).sprite = MouseOverSprite;
}

function OnMouseExit()
{
	 GetComponent(SpriteRenderer).sprite = OriginalSprite;
}

function OnMouseDown()
{
	Application.LoadLevel("TheGame");
}
function Update () {

}