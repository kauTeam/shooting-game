using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class install : MonoBehaviour {


	public Sprite[] Attack_sk_img =new Sprite[5];
	public Sprite[] Defence_sk_img =new Sprite[5];

	public GameObject attack_img;
	public GameObject defence_img;

	string[] attack_name={"Meteor","Poison","FireBall","IceGun","HellDrop"};
	string[] defence_name={"Barrier","Shild","Heal","DotHeal","Reflect"};

	public Text attack_sk_name;
	public Text defence_sk_name;
	public Text attack_sk_LV;
	public Text defence_sk_LV;

	// Use this for initialization
	void start()
	{
		attack_sk_name = gameObject.GetComponent<Text> ();
		defence_sk_name = gameObject.GetComponent<Text> ();
		attack_sk_LV = gameObject.GetComponent<Text> ();
		defence_sk_LV = gameObject.GetComponent<Text> ();
			
	}
	void Awake()
	{
		if (!PlayerPrefs.HasKey ("attack")) {
			PlayerPrefs.SetInt ("attack", 1);
		}
		if (!PlayerPrefs.HasKey ("defence")) {
			PlayerPrefs.SetInt ("defence", 1);
		}
	}
	// Update is called once per frame
	void Update () {
		int attack = PlayerPrefs.GetInt ("attack");
		int defence = PlayerPrefs.GetInt ("defence");
		attack_img.GetComponent<Image> ().sprite = Attack_sk_img [attack-1];
		defence_img.GetComponent<Image> ().sprite = Defence_sk_img [defence-1];
		attack_sk_name.text = attack_name [attack - 1];
		defence_sk_name.text = defence_name [defence - 1];
		attack_sk_LV.text = PlayerPrefs.GetInt (attack_name [attack - 1]).ToString();
		defence_sk_LV.text = PlayerPrefs.GetInt (defence_name [defence - 1]).ToString();
	}
}
