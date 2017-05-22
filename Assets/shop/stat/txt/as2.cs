using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class as2 : MonoBehaviour {
	public Text attack_speed_up;


	void Start () {


		attack_speed_up = gameObject.GetComponent<Text> ();
	}

	void Awake () {
		
		attack_speed_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float attack_speed = PlayerPrefs.GetFloat ("Max_attack_speed");

		attack_speed_up.text = "MAX LV." + (attack_speed+5f).ToString ();

	}
}
