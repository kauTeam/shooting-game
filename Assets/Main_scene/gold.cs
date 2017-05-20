using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gold : MonoBehaviour {

	public Text coin_text;
	// Use this for initialization
	void Start () {
		coin_text = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		coin_text.text = PlayerPrefs.GetInt ("coin").ToString();
	}
}
