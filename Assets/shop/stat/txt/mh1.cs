using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mh1 : MonoBehaviour {
	public Text max_hp_now;

	void Start () {
		
		max_hp_now = gameObject.GetComponent<Text> ();
	}

	void Awake () {



		max_hp_now = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		float max_hp = PlayerPrefs.GetFloat ("Max_Hp");

		max_hp_now.text = "MAX LV." + max_hp.ToString ();
	}
}
