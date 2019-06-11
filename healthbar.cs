using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
public float ehealth;
public float poopoo;

    // Start is called before the first frame update

      void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {  Transform bar = transform.Find("Bar");
      GameObject g = GameObject.Find("PlayerState");
      PlayerState script = g.GetComponent<PlayerState>();
      poopoo = script.PlayerHealth;
      ehealth = (poopoo*0.01f);
      bar.localScale = new Vector3(ehealth , 1f);



    }
}
