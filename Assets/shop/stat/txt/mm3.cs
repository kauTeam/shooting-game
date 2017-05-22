using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm3: MonoBehaviour {
	
	public Text max_mana_cost;


	void Start () {
		

		max_mana_cost = gameObject.GetComponent<Text> ();

	}

	void Awake () {
		max_mana_cost = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		
		float max_mana = PlayerPrefs.GetFloat ("Max_Mana");
		max_mana_cost.text = (max_mana*100f).ToString ();
	}
}
