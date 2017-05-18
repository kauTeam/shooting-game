using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 마나재생TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("Max_Mana_re")) {
			PlayerPrefs.SetFloat ("Max_Mana_re", 5f);
		}
		if (!PlayerPrefs.HasKey ("Mana_re")) {
			PlayerPrefs.SetFloat ("Mana_re", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("Mana_re");
		float max = PlayerPrefs.GetFloat ("Max_Mana_re");
		txt.text = now.ToString()+" / " +max.ToString();
	}
}