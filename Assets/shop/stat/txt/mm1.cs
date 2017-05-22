using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm1 : MonoBehaviour {
	public Text max_mana_now;


	void Start () {
		
		max_mana_now = gameObject.GetComponent<Text> ();
	
	}

	void Awake () {
		max_mana_now = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		
		float max_mana = PlayerPrefs.GetFloat ("Max_Mana");
	
		max_mana_now.text = "MAX LV." + max_mana.ToString ();

	}
}
