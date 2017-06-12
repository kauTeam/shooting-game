using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_train : MonoBehaviour {

	// Use this for initialization
	public GameObject miss = null;
	public Transform loc = null;

	public float attack_speed=3f;
	bool shoot_state=true;
	// Update is called once per frame


	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);
			Instantiate (miss, loc.position, loc.rotation);
			shoot_state = false;
			int exp = PlayerPrefs.GetInt ("exp");
			int level = PlayerPrefs.GetInt ("lv");
			exp++;
			if (exp == level * 10) 
			{
				int point = PlayerPrefs.GetInt ("point");
				exp = 0;
				level++;
				point+=3;
				PlayerPrefs.SetInt ("point", point);
			}
			PlayerPrefs.SetInt ("lv", level);
			PlayerPrefs.SetInt ("exp", exp);

		}
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (miss, loc.position, loc.rotation);
			shoot_state = false;
			int exp = PlayerPrefs.GetInt ("exp");
			int level = PlayerPrefs.GetInt ("lv");
			exp++;
			if (exp == level * 10) 
			{
				int point = PlayerPrefs.GetInt ("point");
				exp = 0;
				level++;
				point+=3;
				PlayerPrefs.SetInt ("point", point);
			}
			PlayerPrefs.SetInt ("lv", level);
			PlayerPrefs.SetInt ("exp", exp);
		}


	}
		
	public void set_shoot_state()
	{
		shoot_state = true;
	}
}




	
