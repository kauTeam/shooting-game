using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State_up : MonoBehaviour {

	// Use this for initialization
	public void Mana_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Mana");
		if (point > 0) {
			point--;
			PlayerPrefs.SetInt ("point", point);
			PlayerPrefs.SetFloat ("Mana", now + 1f);
		}
	}
	public void Hp_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Hp");
		if (point > 0) {
			point--;
			PlayerPrefs.SetInt ("point", point);
			PlayerPrefs.SetFloat ("Hp", now + 1f);
		}
	}
	public void Damage_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Damage");
		if (point > 0) {
			point--;
			PlayerPrefs.SetInt ("point", point);
			PlayerPrefs.SetFloat ("Damage", now + 1f);
		}
	}
	public void Mana_re_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("Mana_re");
		if (point > 0) {
			point--;
			PlayerPrefs.SetInt ("point", point);
			PlayerPrefs.SetFloat ("Mana_re", now + 1f);
		}
	}
	public void attack_speed_up()
	{
		int point = PlayerPrefs.GetInt ("point");
		float now = PlayerPrefs.GetFloat ("attack_speed");
		if (point > 0) {
			point--;
			PlayerPrefs.SetInt ("point", point);
			PlayerPrefs.SetFloat ("attack_speed", now + 1f);
		}
	}
}
