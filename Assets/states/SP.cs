using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SP : MonoBehaviour {

	public Text txt;
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("point")) {
			PlayerPrefs.SetInt ("point", 0);
		}
	}
	void start()
	{
		txt = gameObject.GetComponent<Text> ();
	}
	// Update is called once per frame
	void Update () {
		int point = PlayerPrefs.GetInt ("point");
		txt.text = point.ToString();
	}
}