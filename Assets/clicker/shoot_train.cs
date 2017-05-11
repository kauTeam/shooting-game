using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_train : MonoBehaviour {

	// Use this for initialization
	public GameObject miss = null;
	public Transform loc = null;

	public float attack_speed=3f;
	bool shoot_state=true;
	public int level=1;
	public int exp=0;
	int save=1;
	int point=0;
	// Update is called once per frame

	void Awake()
	{
		if (PlayerPrefs.HasKey ("lv")) {
			level = PlayerPrefs.GetInt ("lv");
		}
		if (PlayerPrefs.HasKey ("point")) {
			point = PlayerPrefs.GetInt ("point");
		}
		if (PlayerPrefs.HasKey ("exp")) {
			exp = PlayerPrefs.GetInt ("exp");
		}
	}

	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);
			Instantiate (miss, loc.position, loc.rotation);
			shoot_state = false;
			exp++;
			save++;
		}
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (miss, loc.position, loc.rotation);
			shoot_state = false;
			exp++;
			save++;
		}
		if (exp == level * 10) 
		{
			exp = 0;
			level++;
			point++;
			PlayerPrefs.SetInt ("point", point);
		}
		if (save == 10) {
			save = 0;
			PlayerPrefs.SetInt ("lv", level);
			PlayerPrefs.SetInt ("exp", exp);
		}
	}
		
	public void set_shoot_state()
	{
		shoot_state = true;
	}
	public void setLevel(int x)
	{
		level = x;
	}
	public void setExp(int x)
	{
		exp = x;
	}
	public int returnLevel()
	{
		return level;
	}
	public int returnExp()
	{
		return exp;
	}
}




	
