using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mr1 : MonoBehaviour {
	
	public Text mana_recover_now;

	// Use this for initialization

	void Start () {
		
		mana_recover_now = gameObject.GetComponent<Text> ();

	}

	void Awake () {



		mana_recover_now = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float mana_recover = PlayerPrefs.GetFloat ("Max_Mana_re");


		mana_recover_now.text = "MAX LV." + mana_recover.ToString ();

	}
}
