using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

	public class Victoria : MonoBehaviour {

			GameObject varGameObject;


	// Use this for initialization
	void Start () {
		varGameObject = GameObject.Find("PlayerCharacter");

	}

	// Update is called once per frame
	void Update () {

	}



void OnTriggerEnter2D(Collider2D col){
	if (col.gameObject.tag == "Player"){
		  SceneManager.LoadScene("Level3-1");
		varGameObject.GetComponent<PlayerControllerScript>().enabled = false;
	}
}
}
