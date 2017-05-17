using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 공격력TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("Max_Damage")) {
			PlayerPrefs.SetFloat ("Max_Damage", 5f);
		}
		if (!PlayerPrefs.HasKey ("Damage")) {
			PlayerPrefs.SetFloat ("Damage", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("Damage");
		float max = PlayerPrefs.GetFloat ("Max_Damage");
		txt.text = now.ToString()+" / " +max.ToString();
	}
}
