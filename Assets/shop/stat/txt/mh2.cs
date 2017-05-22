using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mh2 : MonoBehaviour {
	
	public Text max_hp_up;

	void Start () {
		max_hp_up = gameObject.GetComponent<Text> ();
	}

	void Awake () {
		max_hp_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {

		float max_hp = PlayerPrefs.GetFloat ("Max_Hp");

		max_hp_up.text = "MAX LV." + (max_hp+5f).ToString ();

	}
}
