using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_Skill : MonoBehaviour {

	// Use this for initialization
	public GameObject shild=null;
	public Transform shild_pos=null;
	int attack_Type;
	int defend_Type;
	void Start () {
		if (PlayerPrefs.HasKey ("attack_sill")) {
			attack_Type = PlayerPrefs.GetInt ("attack_sill");
		} else {
			attack_Type = 1;
		}
		if (PlayerPrefs.HasKey ("defend_skill")) {
			defend_Type = PlayerPrefs.GetInt ("defend_skill");
		} else {
			defend_Type = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void attack()
	{
		switch (attack_Type) {
		case 1:
			{
				break;
			}
		}
	}
	public void defend()
	{
		switch (defend_Type) {
		case 1:
			{
				Instantiate (shild, shild_pos.position, shild_pos.rotation);
				break;
			}
		}
	}
}






