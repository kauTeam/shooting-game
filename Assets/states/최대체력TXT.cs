using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 최대체력TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("Max_Hp")) {
			PlayerPrefs.SetFloat ("Max_Hp", 5f);
		}
		if (!PlayerPrefs.HasKey ("Hp")) {
			PlayerPrefs.SetFloat ("Hp", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("Hp");
		float max = PlayerPrefs.GetFloat ("Max_Hp");
		txt.text = now.ToString()+" / " +max.ToString();
	}
}