﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class use_Skill : MonoBehaviour {

    // Use this for initialization
    public GameObject HellFire = null;
    public Transform HellFire_pos1 = null;
    public Transform HellFire_pos2 = null;
    public Transform HellFire_pos3 = null;
    public Transform HellFire_pos4 = null;
    public Transform HellFire_pos5 = null;

	public GameObject shield = null;
	public GameObject Reflect = null;



    public GameObject FireBall = null;
    public Transform FireBall_pos = null;

    public GameObject IceGun = null;
    public Transform IceGun_pos1 = null; 
    public Transform IceGun_pos2 = null;
    public Transform IceGun_pos3 = null;

    public GameObject shild=null;
    public GameObject player = null;
	public Transform shild_pos=null;

	int attack_Type;
	int defend_Type;
	void Start () {
		if (PlayerPrefs.HasKey ("attack")) {
			attack_Type = PlayerPrefs.GetInt ("attack");
		} else {
			attack_Type = 1;
		}
		if (PlayerPrefs.HasKey ("defence")) {
			defend_Type = PlayerPrefs.GetInt ("defence");
		} else {
			defend_Type = 1;
		}
	}


	void DotHeal()
	{
		int heal = PlayerPrefs.GetInt ("DotHeal")*5;
		player.GetComponent<mve> ().heal (heal);
	}

	// Update is called once per frame
	void Update () {
	}

	public void attack()
	{
		switch (attack_Type) {
		case 1:
			{
                    Instantiate(HellFire, HellFire_pos1.position, HellFire_pos1.rotation);
                    Instantiate(HellFire, HellFire_pos2.position, HellFire_pos2.rotation);
                    Instantiate(HellFire, HellFire_pos3.position, HellFire_pos3.rotation);
                    Instantiate(HellFire, HellFire_pos4.position, HellFire_pos4.rotation);
                    Instantiate(HellFire, HellFire_pos5.position, HellFire_pos5.rotation);

                    break;
			}
        case 2:
              {
                    player.GetComponent<shoot>().set_Poison_state();
                    break;
              }
            case 3:
                {
                    Instantiate(FireBall, FireBall_pos.position, FireBall_pos.rotation);
                    break;
                }
            case 4:
                {
                    Instantiate(IceGun, IceGun_pos1.position, IceGun_pos1.rotation);
                    Instantiate(IceGun, IceGun_pos2.position, IceGun_pos2.rotation);
                    Instantiate(IceGun, IceGun_pos3.position, IceGun_pos3.rotation);
                    break;

                }
        }
	}
	public void defend()
	{
		switch (defend_Type) {
		case 1:
			{
				Instantiate (shild, shild_pos.position, shild_pos.rotation);
				break;
			}
		case 2:
			{
				shield.SetActive (true);
				break;
			}
		case 3:
			{
				int heal = PlayerPrefs.GetInt ("Heal") * 30;
				player.GetComponent<mve> ().heal (heal);
				break;
			}
		case 4:
			{
				int heal = PlayerPrefs.GetInt ("DotHeal")*10;
				player.GetComponent<mve> ().heal (heal);
				Invoke ("DotHeal", 0.4f);
				Invoke ("DotHeal", 0.8f);
				Invoke ("DotHeal", 1.2f);
				Invoke ("DotHeal", 1.6f);
				Invoke ("DotHeal", 2f);
				Invoke ("DotHeal", 2.4f);
				Invoke ("DotHeal", 2.8f);
				Invoke ("DotHeal", 3.2f);
				break;
			}
		case 5:
			{
				Reflect.SetActive (true);
				break;
			}
		}
	}
    
}






