using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class poison2 : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		int lv = PlayerPrefs.GetInt ("Poison");
		text.text = (lv * 700).ToString ();
		}
}