using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : PlayerState {

	public Text mytext1 = null;

	void Update () {

		mytext1.text = (PlayerHealth.ToString());


	}
}
