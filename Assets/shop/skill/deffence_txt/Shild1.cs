﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shild1 : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		int lv = PlayerPrefs.GetInt ("Shild");
		text.text = lv.ToString ()+"->" + (lv + 1).ToString ();
	}
}