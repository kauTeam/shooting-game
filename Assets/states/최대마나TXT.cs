using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 최대마나TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("Max_Mana")) {
			PlayerPrefs.SetFloat ("Max_Mana", 5f);
		}
		if (!PlayerPrefs.HasKey ("Mana")) {
			PlayerPrefs.SetFloat ("Mana", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("Mana");
		float max = PlayerPrefs.GetFloat ("Max_Mana");
		txt.text = now.ToString()+" / " +max.ToString();
	}
}