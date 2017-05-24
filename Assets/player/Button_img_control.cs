using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button_img_control : MonoBehaviour {


	public Sprite[] Attack_sk_img =new Sprite[5];
	public Sprite[] Defence_sk_img =new Sprite[5];

	public GameObject attack_img;
	public GameObject defence_img;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int attack = PlayerPrefs.GetInt ("attack");
		int defence = PlayerPrefs.GetInt ("defence");
		attack_img.GetComponent<Image> ().sprite = Attack_sk_img [attack-1];
		defence_img.GetComponent<Image> ().sprite = Defence_sk_img [defence-1];
	}
}
