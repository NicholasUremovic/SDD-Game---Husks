using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerScript : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;

	private Animator anim;

	// Use this for initialization
		void Start () {

			moveSpeed = GlobalControl.Instance.moveSpeed;
			myRigidbody = GetComponent<Rigidbody2D>();
			anim = GetComponent<Animator>();
		}

	//Horizontal and Vertical Movements
		void Update () {
			if(Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
			{
					//transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
					myRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, myRigidbody.velocity.y);
				}


			if(Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
				{
					//transform.Translate (new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
					myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed);

				}// Anti Sprite Spin Code
		  if(Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f){
					myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y);
			}
			if(Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f){
				myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, 0f);

//Animations
			}
			anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
			anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));



}
public void SavePlayer()
{
	 GlobalControl.Instance.moveSpeed = moveSpeed;

	 }
}
