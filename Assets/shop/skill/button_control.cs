using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_control : MonoBehaviour {

	// Use this for initialization


	public void at_skill1()
	{
		int lv = PlayerPrefs.GetInt ("Meteor");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Meteor", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void at_skill2()
	{
		int lv = PlayerPrefs.GetInt ("Poison");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Poison", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void at_skill3()
	{
		int lv = PlayerPrefs.GetInt ("FireBall");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("FireBall", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void at_skill4()
	{
		int lv = PlayerPrefs.GetInt ("IceGun");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("IceGun", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void at_skill5()
	{
		int lv = PlayerPrefs.GetInt ("HellDrop");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("HellDrop", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}

	public void df_skill1()
	{
		int lv = PlayerPrefs.GetInt ("Barrier");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Barrier", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void df_skill2()
	{
		int lv = PlayerPrefs.GetInt ("Shild");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Shild", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void df_skill3()
	{
		int lv = PlayerPrefs.GetInt ("Heal");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Heal", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void df_skill4()
	{
		int lv = PlayerPrefs.GetInt ("DotHeal");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("DotHeal", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}
	public void df_skill5()
	{
		int lv = PlayerPrefs.GetInt ("Reflect");
		int coin = PlayerPrefs.GetInt ("coin");
		if (lv * 700 <= coin) {
			PlayerPrefs.SetInt ("Reflect", lv + 1);
			PlayerPrefs.SetInt ("coin", coin - lv * 700);
		}
	}

}
