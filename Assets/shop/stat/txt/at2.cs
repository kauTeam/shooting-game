using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class at2 : MonoBehaviour {


	public Text damage_up;

	// Use this for initialization

	void Start () {

	
		damage_up = gameObject.GetComponent<Text> ();

	}

	void Awake () {

	
		damage_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		float damage = PlayerPrefs.GetFloat ("Max_Damage");

		damage_up.text = "MAX LV." + (damage+5f).ToString ();

	}
}
