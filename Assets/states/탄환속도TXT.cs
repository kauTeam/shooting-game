using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 탄환속도TXT : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("tan_speed")) {
			PlayerPrefs.SetFloat ("tan_speed", 1f);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		float now = PlayerPrefs.GetFloat ("tan_speed");
		txt.text = now.ToString();
	}
}