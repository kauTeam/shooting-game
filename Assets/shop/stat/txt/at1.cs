using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class at1 : MonoBehaviour {

	public Text damage_now;
	// Use this for initialization

	void Start () {

		damage_now = gameObject.GetComponent<Text> ();
	}

	void Awake () {

		damage_now = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		float damage = PlayerPrefs.GetFloat ("Max_Damage");


		damage_now.text = "MAX LV." + damage.ToString ();
	}
}
