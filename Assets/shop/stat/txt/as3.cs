using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class as3 : MonoBehaviour {


	public Text attack_speed_cost;


	void Start () {
		
		attack_speed_cost = gameObject.GetComponent<Text> ();

	}

	void Awake () {


		attack_speed_cost = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float attack_speed = PlayerPrefs.GetFloat ("Max_attack_speed");

		attack_speed_cost.text = (attack_speed * 100f).ToString ();

	}
}
