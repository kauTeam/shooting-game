﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ts2 : MonoBehaviour {

	public Text tan_speed_up;


	void Start () {
		
		tan_speed_up = gameObject.GetComponent<Text> ();

	}

	void Awake () {


		tan_speed_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float tan_speed = PlayerPrefs.GetFloat ("tan_speed");
	
		tan_speed_up.text = "LV." + (tan_speed+1f).ToString ();

	}
}
