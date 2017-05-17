using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Defence_skill : MonoBehaviour {

	public Text sk1;
	public Text sk2;
	public Text sk3;
	public Text sk4;
	public Text sk5;

	void Awake()
	{

		if (!PlayerPrefs.HasKey ("Barrier")) {
			PlayerPrefs.SetInt ("Barrier", 1);
		}
		if (!PlayerPrefs.HasKey ("Shild")) {
			PlayerPrefs.SetInt ("Shild", 2);
		}
		if (!PlayerPrefs.HasKey ("Heal")) {
			PlayerPrefs.SetInt ("Heal", 3);
		}
		if (!PlayerPrefs.HasKey ("DotHeal")) {
			PlayerPrefs.SetInt ("DotHeal", 4);
		}
		if (!PlayerPrefs.HasKey ("Reflect")) {
			PlayerPrefs.SetInt ("Reflect", 5);
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
		int point1 = PlayerPrefs.GetInt ("Barrier");
		sk1.text = point1.ToString();
		int point2 = PlayerPrefs.GetInt ("Shild");
		sk2.text = point2.ToString();
		int point3 = PlayerPrefs.GetInt ("Heal");
		sk3.text = point3.ToString();
		int point4 = PlayerPrefs.GetInt ("DotHeal");
		sk4.text = point4.ToString();
		int point5 = PlayerPrefs.GetInt ("Reflect");
		sk5.text = point5.ToString();
	}
}