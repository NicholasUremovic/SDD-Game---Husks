using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
  public float PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {  Time.timeScale = 1f;

        PlayerHealth = GlobalControl.Instance.PlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

       public void TakeDamage (int damage)
     	{
     		PlayerHealth -= damage;

     		if (PlayerHealth <= 0)
     		{
     			Die();
     		}
     	}

     	void Die ()
     	{
     		Destroy(gameObject,5);
     	}
      public void SavePlayer()
     {
         GlobalControl.Instance.PlayerHealth = PlayerHealth;

         }

     }
