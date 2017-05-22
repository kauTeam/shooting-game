using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class at3 : MonoBehaviour {
	
	public Text damage_cost;


	void Start () {


		damage_cost = gameObject.GetComponent<Text> ();

	}

	void Awake () {

	
		damage_cost = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		float damage = PlayerPrefs.GetFloat ("Max_Damage");


		damage_cost.text = (damage * 100f).ToString ();

}
}