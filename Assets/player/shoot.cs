using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public GameObject miss = null;
	public Transform loc = null;
	public float attack_speed=1f;
	public float damage=1f;
	bool shoot_state=true;
	// Update is called once per frame
	void Start()
	{
		if (PlayerPrefs.HasKey ("Damage")) 
		{
			damage = PlayerPrefs.GetFloat ("Damage");
		}
	}
	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);
			Instantiate (miss, loc.position, loc.rotation);
			shoot_state = false;
			
		}
	}
	void set_shoot_state()
	{
		shoot_state = true;
	}
}
