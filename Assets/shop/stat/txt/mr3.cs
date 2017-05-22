using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mr3 : MonoBehaviour {
	
	public Text mana_recover_cost;

	void Start () {
		
		mana_recover_cost = gameObject.GetComponent<Text> ();

	}

	void Awake () {
		
		mana_recover_cost = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float mana_recover = PlayerPrefs.GetFloat ("Max_Mana_re");

		mana_recover_cost.text = (mana_recover * 100f).ToString ();

	}
}
