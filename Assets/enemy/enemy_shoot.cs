using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_shoot : MonoBehaviour {

	public GameObject miss1 = null;

	public Transform loc = null;
	public float attack_speed=1f;
	bool shoot_state=true;
	// Update is called once per frame
	void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);
			GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
			tan1.gameObject.GetComponent<enemy_tan>().setType (Random.Range (1, 5));
			GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
			tan2.gameObject.GetComponent<enemy_tan>().setType (Random.Range (1, 5));
			GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
			tan3.gameObject.GetComponent<enemy_tan>().setType (Random.Range (1, 5));
			GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
			tan4.gameObject.GetComponent<enemy_tan>().setType (Random.Range (1, 5));
			shoot_state = false;

		}
	}
	void set_shoot_state()
	{
		shoot_state = true;
	}
}
