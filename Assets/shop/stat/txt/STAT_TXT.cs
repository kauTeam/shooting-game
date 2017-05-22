using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STAT_TXT : MonoBehaviour {

	public Text damage_now;
	public Text damage_up;
	public Text damage_cost;

	public Text attack_speed_now;
	public Text attack_speed_up;
	public Text attack_speed_cost;

	public Text tan_speed_now;
	public Text tan_speed_up;
	public Text tan_speed_cost;

	public Text max_mana_now;
	public Text max_mana_up;
	public Text max_mana_cost;

	public Text mana_recover_now;
	public Text mana_recover_up;
	public Text mana_recover_cost;


	public Text max_hp_now;
	public Text max_hp_up;
	public Text max_hp_cost;

	// Use this for initialization

	void Start () {

		damage_now = gameObject.GetComponent<Text> ();
		damage_up = gameObject.GetComponent<Text> ();
		damage_cost = gameObject.GetComponent<Text> ();

		attack_speed_now = gameObject.GetComponent<Text> ();
		attack_speed_up = gameObject.GetComponent<Text> ();
		attack_speed_cost = gameObject.GetComponent<Text> ();

		tan_speed_now = gameObject.GetComponent<Text> ();
		tan_speed_up = gameObject.GetComponent<Text> ();
		tan_speed_cost = gameObject.GetComponent<Text> ();

		max_mana_now = gameObject.GetComponent<Text> ();
		max_mana_up = gameObject.GetComponent<Text> ();
		max_mana_cost = gameObject.GetComponent<Text> ();

		mana_recover_now = gameObject.GetComponent<Text> ();
		mana_recover_up = gameObject.GetComponent<Text> ();
		mana_recover_cost = gameObject.GetComponent<Text> ();

		max_hp_now = gameObject.GetComponent<Text> ();
		max_hp_up = gameObject.GetComponent<Text> ();
		max_hp_cost = gameObject.GetComponent<Text> ();
	}

	void Awake () {

		damage_now = gameObject.GetComponent<Text> ();
		damage_up = gameObject.GetComponent<Text> ();
		damage_cost = gameObject.GetComponent<Text> ();

		attack_speed_now = gameObject.GetComponent<Text> ();
		attack_speed_up = gameObject.GetComponent<Text> ();
		attack_speed_cost = gameObject.GetComponent<Text> ();

		tan_speed_now = gameObject.GetComponent<Text> ();
		tan_speed_up = gameObject.GetComponent<Text> ();
		tan_speed_cost = gameObject.GetComponent<Text> ();

		max_mana_now = gameObject.GetComponent<Text> ();
		max_mana_up = gameObject.GetComponent<Text> ();
		max_mana_cost = gameObject.GetComponent<Text> ();

		mana_recover_now = gameObject.GetComponent<Text> ();
		mana_recover_up = gameObject.GetComponent<Text> ();
		mana_recover_cost = gameObject.GetComponent<Text> ();

		max_hp_now = gameObject.GetComponent<Text> ();
		max_hp_up = gameObject.GetComponent<Text> ();
		max_hp_cost = gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		float damage = PlayerPrefs.GetFloat ("Max_Damage");
		float attack_speed = PlayerPrefs.GetFloat ("Max_attack_speed");
		float tan_speed = PlayerPrefs.GetFloat ("tan_speed");
		float max_mana = PlayerPrefs.GetFloat ("Max_Mana");
		float mana_recover = PlayerPrefs.GetFloat ("Max_Mana_re");
		float max_hp = PlayerPrefs.GetFloat ("Max_Hp");

		damage_now.text = "MAX LV." + damage.ToString ();
		damage_up.text = "MAX LV." + (damage+5f).ToString ();
		damage_cost.text = (damage * 100f).ToString ();

		attack_speed_now.text = "MAX LV." + attack_speed.ToString ();
		attack_speed_up.text = "MAX LV." + (attack_speed+5f).ToString ();
		attack_speed_cost.text = (attack_speed * 100f).ToString ();

		tan_speed_now.text = "LV." + tan_speed.ToString ();
		tan_speed_up.text = "LV." + (tan_speed+1f).ToString ();
		tan_speed_cost.text = (tan_speed * 1000f).ToString ();

		max_mana_now.text = "MAX LV." + max_mana.ToString ();
		max_mana_up.text = "MAX LV." + (max_mana+5f).ToString ();
		max_mana_cost.text = (max_mana * 100f).ToString ();

		mana_recover_now.text = "MAX LV." + mana_recover.ToString ();
		mana_recover_up.text = "MAX LV." + (mana_recover+5f).ToString ();
		mana_recover_cost.text = (mana_recover * 100f).ToString ();

		max_hp_now.text = "MAX LV." + max_hp.ToString ();
		max_hp_up.text = "MAX LV." + (max_hp+5f).ToString ();
		max_hp_cost.text = (max_hp * 100f).ToString ();
	}
}
