using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exp : MonoBehaviour {

	// Use this for initialization
	public GameObject user;
	public Text exp;
	void start()
	{
		exp = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		int exper=PlayerPrefs.GetInt("exp");
		int level = PlayerPrefs.GetInt ("lv");
		exp.text = "Exp: " + exper.ToString()+"/"+(level*10).ToString();

	}
}
