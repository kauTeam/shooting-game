using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ts1 : MonoBehaviour {


	public Text tan_speed_now;


	void Start () {
		
		tan_speed_now = gameObject.GetComponent<Text> ();

	}

	void Awake () {


		tan_speed_now = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {

		float tan_speed = PlayerPrefs.GetFloat ("tan_speed");

		tan_speed_now.text = "LV." + tan_speed.ToString ();

	}
}
