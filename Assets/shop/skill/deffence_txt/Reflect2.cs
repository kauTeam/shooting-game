﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reflect2 : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		int lv = PlayerPrefs.GetInt ("Reflect");
		text.text = (lv*700).ToString();
	}
}