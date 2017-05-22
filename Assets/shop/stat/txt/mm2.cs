using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm2 : MonoBehaviour {
	public Text max_mana_up;
	void Start () {
		max_mana_up = gameObject.GetComponent<Text> ();

	}

	void Awake () {


		max_mana_up = gameObject.GetComponent<Text> ();

	}

	// Update is called once per frame
	void Update () {
		
		float max_mana = PlayerPrefs.GetFloat ("Max_Mana");

		max_mana_up.text = "MAX LV." + (max_mana+5f).ToString ();

}
}
