using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2 : MonoBehaviour {

	public float speed = 20f;
	public int enbdamage = 40;
	public Rigidbody2D rb;
	public GameObject impactEffect;

	// Use this for initialization
	void Start () {
		rb.velocity = transform.right * speed;
	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
    PlayerState player = hitInfo.GetComponent<PlayerState>();
		if (player != null)
		{

			player.TakeDamage(enbdamage);
		}
Instantiate(impactEffect, transform.position, transform.rotation);
		Destroy(gameObject);
	}}
