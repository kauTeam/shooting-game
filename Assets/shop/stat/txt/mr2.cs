using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mr2 : MonoBehaviour {
	
	public Text mana_recover_up;

	void Start () {


		mana_recover_up = gameObject.GetComponent<Text> ();

	}

	void Awake () {
		
		mana_recover_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float mana_recover = PlayerPrefs.GetFloat ("Max_Mana_re");

		mana_recover_up.text = "MAX LV." + (mana_recover+5f).ToString ();

	}
}
