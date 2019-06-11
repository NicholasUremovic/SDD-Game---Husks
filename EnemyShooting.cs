using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

	public Transform enFirepoint1;
  public Transform enFirepoint2;
  public Transform enFirepoint3;
  public Transform enFirepoint4;
	public GameObject bullet2Prefab;
  public bool fire = false;
	// Update is called once per frame
  void Update () {

		if (fire==true)
		{StartCoroutine (Timer());
			Shoot1();
		}

    if (fire==true)
		{StartCoroutine (Timer());
			Shoot2();
		}
    if (fire==true)
		{StartCoroutine (Timer());
			Shoot3();
		}
    if (fire==true)
		{StartCoroutine (Timer());
			Shoot4();
		}
	}
  void OnTriggerEnter2D (Collider2D hitInfo)
	{
		PlayerState player = hitInfo.GetComponent<PlayerState>();
		if (player != null)
		{
			fire=true;
		}}
  void OnTriggerExit2D (Collider2D hitInfo)
    {
      PlayerState player = hitInfo.GetComponent<PlayerState>();
      if (player != null)
      {
        fire=false;
      }


  }
  IEnumerator Timer() {
    yield return new WaitForSeconds (1);
  }

	void Shoot1 ()
	{
		Instantiate(bullet2Prefab, enFirepoint1.position, enFirepoint1.rotation);

	}


  void Shoot2 ()
	{
		Instantiate(bullet2Prefab, enFirepoint2.position, enFirepoint2.rotation);
	}
  void Shoot3 ()
	{
		Instantiate(bullet2Prefab, enFirepoint3.position, enFirepoint3.rotation);
	}
  void Shoot4 ()
	{
		Instantiate(bullet2Prefab, enFirepoint4.position, enFirepoint4.rotation);
	}
}
