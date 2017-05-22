using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soul : MonoBehaviour {


	public Text soul_text;

	// Use this for initialization
	void Start () {
		soul_text = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		soul_text.text = PlayerPrefs.GetInt ("soul").ToString();
	}
}