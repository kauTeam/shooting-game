using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public GameObject miss = null;
	public Transform loc = null;
	public float attack_speed;
	public float damage;
	public float tan_speed;
	bool shoot_state=true;

    // Update is called once per frame
    void Start()
	{
		if (PlayerPrefs.HasKey ("Damage")) {
			damage = PlayerPrefs.GetFloat ("Damage");
		} else {
			damage = 30f;
		}
		if (PlayerPrefs.HasKey ("attack_speed")) {
			attack_speed = PlayerPrefs.GetFloat ("attack_speed");
		} else {
			attack_speed = 1f;
		}
		if (PlayerPrefs.HasKey ("tan_speed")) {
			tan_speed = PlayerPrefs.GetFloat ("tan_speed");
		} else {
			tan_speed = 20f;
		}
	}
	void Update () 
	{
		if (shoot_state) 
		{
			//Invoke ("set_shoot_state", attack_speed);
			GameObject tan1=Instantiate (miss, loc.position, loc.rotation);
			tan1.GetComponent<tan>().setDamage (damage);
			tan1.GetComponent<tan>().setSpeed (tan_speed);
			shoot_state = false;
			
		}
	}
	void set_shoot_state()
	{
		shoot_state = true;
	}
}
