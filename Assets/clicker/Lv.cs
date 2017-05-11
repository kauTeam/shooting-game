using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
	
public class Lv : MonoBehaviour {

	// Use this for initialization
	public GameObject user;
	public Text lv;
	void start()
	{
		lv = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		int level=user.GetComponent<shoot_train>().returnLevel();
		//level = 1;
		lv.text = "LV: " + level.ToString();

	}
}
