using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public int endamage = 40;

	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerState player = hitInfo.GetComponent<PlayerState>();
		if (player != null)
		{
			player.TakeDamage(endamage);
		}

	}
}
