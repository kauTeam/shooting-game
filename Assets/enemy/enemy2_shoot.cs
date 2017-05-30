using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_shoot : MonoBehaviour {

	public GameObject miss1 = null;

	public Transform loc = null;
	public float attack_speed=1f;
	public int damage=20;
	public int tan_speed = 13;
	public bool[] type=new bool[9];
	public int type_count=0;
	int[] vc=new int[9];
	bool shoot_state=true;
    // Update is called once per frame
    
	void Awake()
	{
		for (int i = 0; i < type.Length; i++) {
			if (type [i]) {
				print (type_count);
				vc [type_count] = i;
				type_count++;
			}
		}
	}


    void Update () 
	{
		if (shoot_state) 
		{
			Invoke ("set_shoot_state", attack_speed);

			int pattern = Random.Range (0, type_count-1);
			switch (vc[pattern]) {
			case 0:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (2);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (3);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

				
					break;
				}
			case 1:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (4);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (5);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					break;
				}
			case 2:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (6);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (7);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					break;
				}
			case 3:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (8);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (9);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);
						
					break;
				}
			case 4:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (2);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (3);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (4);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
					tan4.GetComponent<enemy_tan>().setType (5);
					tan4.GetComponent<enemy_tan>().setDamage (damage);
					tan4.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					break;
				}
			case 5:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (2);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (3);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
					tan4.GetComponent<enemy_tan>().setType (4);
					tan4.GetComponent<enemy_tan>().setDamage (damage);
					tan4.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan5=Instantiate (miss1, loc.position, loc.rotation);
					tan5.GetComponent<enemy_tan>().setType (5);
					tan5.GetComponent<enemy_tan>().setDamage (damage);
					tan5.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					break;
				}
			case 6:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (2);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (3);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
					tan4.GetComponent<enemy_tan>().setType (10);
					tan4.GetComponent<enemy_tan>().setDamage (damage);
					tan4.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan5=Instantiate (miss1, loc.position, loc.rotation);
					tan5.GetComponent<enemy_tan>().setType (11);
					tan5.GetComponent<enemy_tan>().setDamage (damage);
					tan5.GetComponent<enemy_tan> ().setSpeed (tan_speed);
					break;
				}
			case 7:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setScale (1,1,1);// 탄크기2배
					tan1.GetComponent<enemy_tan>().setDamage (damage*2);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);
					break;
				}
			case 8:
				{

					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setScale (1,1,1);// 탄크기2배
					tan1.GetComponent<enemy_tan>().setDamage (damage*2);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);


					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (2);
					tan2.GetComponent<enemy_tan>().setScale (1,1,1);// 탄크기2배
					tan2.GetComponent<enemy_tan>().setDamage (damage*2);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);



					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (3);
					tan3.GetComponent<enemy_tan>().setScale (1,1,1);// 탄크기2배
					tan3.GetComponent<enemy_tan>().setDamage (damage*2);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);


					break;
				}
			case 9:
				{
					GameObject tan1=Instantiate (miss1, loc.position, loc.rotation);
					tan1.GetComponent<enemy_tan>().setType (1);
					tan1.GetComponent<enemy_tan>().setDamage (damage);
					tan1.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan2=Instantiate (miss1, loc.position, loc.rotation);
					tan2.GetComponent<enemy_tan>().setType (2);
					tan2.GetComponent<enemy_tan>().setDamage (damage);
					tan2.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan3=Instantiate (miss1, loc.position, loc.rotation);
					tan3.GetComponent<enemy_tan>().setType (3);
					tan3.GetComponent<enemy_tan>().setDamage (damage);
					tan3.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan4=Instantiate (miss1, loc.position, loc.rotation);
					tan4.GetComponent<enemy_tan>().setType (8);
					tan4.GetComponent<enemy_tan>().setDamage (damage);
					tan4.GetComponent<enemy_tan> ().setSpeed (tan_speed);

					GameObject tan5=Instantiate (miss1, loc.position, loc.rotation);
					tan5.GetComponent<enemy_tan>().setType (9);
					tan5.GetComponent<enemy_tan>().setDamage (damage);
					tan5.GetComponent<enemy_tan> ().setSpeed (tan_speed);
					break;
				}
			}
			shoot_state = false;

		}
	}
	void set_shoot_state()
	{
		shoot_state = true;
	}
}


