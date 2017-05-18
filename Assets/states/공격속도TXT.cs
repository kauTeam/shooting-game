using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 공격속도TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("Max_attack_speed")) {
			PlayerPrefs.SetFloat ("Max_attack_speed", 5f);
		}
		if (!PlayerPrefs.HasKey ("attack_speed")) {
			PlayerPrefs.SetFloat ("attack_speed", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("attack_speed");
		float max = PlayerPrefs.GetFloat ("Max_attack_speed");
		txt.text = now.ToString()+" / " +max.ToString();
	}
}