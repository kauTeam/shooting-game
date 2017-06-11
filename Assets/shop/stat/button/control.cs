using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {

	public void damage_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = ((int)PlayerPrefs.GetFloat ("Max_Damage"))*100;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("Max_Damage",(float)cost/100+5f);
		}

	}
	public void as_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = (int)PlayerPrefs.GetFloat ("Max_attack_speed")*100;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("Max_attack_speed",(float)cost/100+5f);
		}
	}
	public void ts_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = (int)PlayerPrefs.GetFloat ("tan_speed")*1000;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("tan_speed",(float)cost/1000+1f);
		}
	}
	public void max_mana_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = (int)PlayerPrefs.GetFloat ("Max_Mana")*100;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("Max_Mana",(float)cost/100+5f);
		}
	}
	public void mana_re_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = (int)PlayerPrefs.GetFloat ("Max_Mana_re")*100;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("Max_Mana_re",(float)cost/100+5f);
		}
	}
	public void hp_up()
	{
		int coin = PlayerPrefs.GetInt ("coin");
		int cost = (int)PlayerPrefs.GetFloat ("Max_Hp")*100;
		if (coin >= cost) {
			coin -= cost;
			PlayerPrefs.SetInt ("coin",coin);
			PlayerPrefs.SetFloat ("Max_Hp",(float)cost/100+5f);
		}
	}
}
