using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ts3 : MonoBehaviour {


	public Text tan_speed_cost;


	void Start () {

	
		tan_speed_cost = gameObject.GetComponent<Text> ();

	}

	void Awake () {
		
		tan_speed_cost = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		
		float tan_speed = PlayerPrefs.GetFloat ("tan_speed");

		tan_speed_cost.text = (tan_speed * 1000f).ToString ();


	}
}
