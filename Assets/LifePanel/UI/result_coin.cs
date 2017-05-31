using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result_coin : MonoBehaviour {

	public Text text;
	// Use this for initialization
	int result;
	void Start () {
		result = PlayerPrefs.GetInt ("get_coin");
		PlayerPrefs.SetInt ("get_coin", 0);
	}

	// Update is called once per frame
	void Update () {
		
		text.text = result.ToString () + "++";
	}
}
