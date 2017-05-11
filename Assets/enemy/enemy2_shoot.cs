	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_shoot : MonoBehaviour {

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
			tan1.GetComponent<enemy_tan>().setType (1);
			//tan1.GetComponent<enemy_tan>().setScale (1,1,1);// 탄크기2배
			//tan1.GetComponent<enemy_tan>().setSpeed (20);// 탄속2배

			GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
			tan2.GetComponent<enemy_tan>().setType (8);
			GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
			tan3.GetComponent<enemy_tan>().setType (9);
			/*GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
			tan4.GetComponent<enemy_tan>().setType (4);
			GameObject tan5=Instantiate (miss1, loc.position, loc.rotation);
			tan5.GetComponent<enemy_tan>().setType (5);
*/
			shoot_state = false;

		}
	}
	void set_shoot_state()
	{
		shoot_state = true;
	}
}

