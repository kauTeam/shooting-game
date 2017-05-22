using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mh3 : MonoBehaviour {

	public Text max_hp_cost;

	// Use this for initialization

	void Start () {
		
		max_hp_cost = gameObject.GetComponent<Text> ();
	}

	void Awake () {

		max_hp_cost = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		float max_hp = PlayerPrefs.GetFloat ("Max_Hp");

		max_hp_cost.text = (max_hp * 100f).ToString ();
	}
}
