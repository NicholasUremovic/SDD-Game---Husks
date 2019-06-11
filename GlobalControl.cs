using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public float PlayerHealth;
    public float moveSpeed;
    public int damage;
    public static GlobalControl Instance;

    void Awake ()
       {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
      }

}
