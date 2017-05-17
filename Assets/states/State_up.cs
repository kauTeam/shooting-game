using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_up : MonoBehaviour {

	// Use this for initialization
	public void Mana_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Mana");
		float max = PlayerPrefs.GetFloat ("Max_Mana");
		if (max > now) {
			if (point > 0) {
				point--;
				PlayerPrefs.SetInt ("point", point);
				PlayerPrefs.SetFloat ("Mana", now + 1f);
			}
		}
	}
	public void Hp_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Hp");
		float max = PlayerPrefs.GetFloat ("Max_Hp");
		if (max > now) {
			if (point > 0) {
				point--;
				PlayerPrefs.SetInt ("point", point);
				PlayerPrefs.SetFloat ("Hp", now + 1f);
			}
		}
	}
	public void Damage_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Damage");
		float max = PlayerPrefs.GetFloat ("Max_Damage");
		if (max > now) {
			if (point > 0) {
				point--;
				PlayerPrefs.SetInt ("point", point);
				PlayerPrefs.SetFloat ("Damage", now + 1f);
			}
		}
	}
	public void Mana_re_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Mana_re");
		float max = PlayerPrefs.GetFloat ("Max_Mana_re");
		if (max > now) {
			if (point > 0) {
				point--;
				PlayerPrefs.SetInt ("point", point);
				PlayerPrefs.SetFloat ("Mana_re", now + 1f);
			}
		}
	}
	public void attack_speed_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("attack_speed");
		float max = PlayerPrefs.GetFloat ("Max_attack_speed");
		if (max > now) {
			if (point > 0) {
				point--;
				PlayerPrefs.SetInt ("point", point);
				PlayerPrefs.SetFloat ("attack_speed", now + 1f);
			}
		}
	}
}
