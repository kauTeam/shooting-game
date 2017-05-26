using System.Collections;
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
    public GameObject player = null;
    public GameObject shild=null;
	public Transform shild_pos=null;

	int attack_Type;
	int defend_Type;
	void Start () {
		if (PlayerPrefs.HasKey ("attack_sill")) {
			attack_Type = PlayerPrefs.GetInt ("attack_sill");
		} else {
			attack_Type = 1;
		}
		if (PlayerPrefs.HasKey ("defend_skill")) {
			defend_Type = PlayerPrefs.GetInt ("defend_skill");
		} else {
			defend_Type = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void attack()
	{
		switch (attack_Type) {
		case 2:
			{
                    Instantiate(HellFire, HellFire_pos1.position, HellFire_pos1.rotation);
                    Instantiate(HellFire, HellFire_pos2.position, HellFire_pos2.rotation);
                    Instantiate(HellFire, HellFire_pos3.position, HellFire_pos3.rotation);
                    Instantiate(HellFire, HellFire_pos4.position, HellFire_pos4.rotation);
                    Instantiate(HellFire, HellFire_pos5.position, HellFire_pos5.rotation);

                    break;
			}
        case 1:
              {
                    shoot_poison();
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
		}
	}

    public void shoot_poison()
    {
        player.gameObject.GetComponent<shoot>().set_Poison_state();
    }
    
}






