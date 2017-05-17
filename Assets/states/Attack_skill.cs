using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack_skill : MonoBehaviour {

	public Text sk1;
	public Text sk2;
	public Text sk3;
	public Text sk4;
	public Text sk5;

	void Awake()
	{
		
		if (!PlayerPrefs.HasKey ("Meteor")) {
			PlayerPrefs.SetInt ("Meteor", 1);
		}
		if (!PlayerPrefs.HasKey ("Poison")) {
			PlayerPrefs.SetInt ("Poison", 2);
		}
		if (!PlayerPrefs.HasKey ("FireBall")) {
			PlayerPrefs.SetInt ("FireBall", 3);
		}
		if (!PlayerPrefs.HasKey ("IceGun")) {
			PlayerPrefs.SetInt ("IceGun", 4);
		}
		if (!PlayerPrefs.HasKey ("HellDrop")) {
			PlayerPrefs.SetInt ("HellDrop", 5);
		}
	}
	void start()
	{
		sk1 = gameObject.GetComponent<Text> ();
		sk2 = gameObject.GetComponent<Text> ();
		sk3 = gameObject.GetComponent<Text> ();
		sk4 = gameObject.GetComponent<Text> ();
		sk5 = gameObject.GetComponent<Text> ();

	}
	// Update is called once per frame
	void Update () {
		int point1 = PlayerPrefs.GetInt ("Meteor");
		sk1.text = point1.ToString();
		int point2 = PlayerPrefs.GetInt ("Poison");
		sk2.text = point2.ToString();
		int point3 = PlayerPrefs.GetInt ("FireBall");
		sk3.text = point3.ToString();
		int point4 = PlayerPrefs.GetInt ("IceGun");
		sk4.text = point4.ToString();
		int point5 = PlayerPrefs.GetInt ("HellDrop");
		sk5.text = point5.ToString();
	}
}