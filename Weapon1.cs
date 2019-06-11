using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour {

	public Transform Firepoint1;
  public Transform Firepoint2;
  public Transform Firepoint3;
  public Transform Firepoint4;
	public GameObject bulletPrefab;

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1"))
		{
			Shoot1();
		}
    if (Input.GetButtonDown("Fire2"))
		{
			Shoot2();
		}
    if (Input.GetButtonDown("Fire3"))
		{
			Shoot3();
		}
    if (Input.GetButtonDown("down"))
		{
			Shoot4();
		}
	}

	void Shoot1 ()
	{
		Instantiate(bulletPrefab, Firepoint1.position, Firepoint1.rotation);
	}
  void Shoot2 ()
	{
		Instantiate(bulletPrefab, Firepoint2.position, Firepoint2.rotation);
	}
  void Shoot3 ()
	{
		Instantiate(bulletPrefab, Firepoint3.position, Firepoint3.rotation);
	}
  void Shoot4 ()
	{
		Instantiate(bulletPrefab, Firepoint4.position, Firepoint4.rotation);
	}
}
