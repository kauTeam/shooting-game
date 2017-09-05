using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class User_SKillCoolDown : MonoBehaviour {

	public List<Skill> skills;
	public int mana;
	public GameObject player;
	public ParticleSystem skill_on;
	public bool Skill_State = false;
	int deffence;
	int attack;
	int[] deffence_mana = new int[6];
	int[] attack_mana=new int[6];
	// Use this for initialization
	void Start () {
		skills [0].cooldown = new float[6];
		skills [1].cooldown = new float[6];
		skills [0].currentCoolDown = new float[6];
		skills [1].currentCoolDown = new float[6];

		attack = PlayerPrefs.GetInt ("attack");
		deffence = PlayerPrefs.GetInt ("defence");

		int meteor = PlayerPrefs.GetInt ("Meteor");
		int poison = PlayerPrefs.GetInt ("Poison");
		int fireball = PlayerPrefs.GetInt ("FireBall");
		int icegun = PlayerPrefs.GetInt ("IceGun");
		int helldrop = PlayerPrefs.GetInt ("HellDrop");

		int barrier = PlayerPrefs.GetInt ("Barrier");
		int shield = PlayerPrefs.GetInt ("Shield");
		int heal = PlayerPrefs.GetInt ("Heal");
		int dotheal = PlayerPrefs.GetInt ("DotHeal");
		int reflect = PlayerPrefs.GetInt ("Reflect");

		skills [0].cooldown [1] = 8f;
		skills [0].cooldown [2] = 4f;
		skills [0].cooldown [3] = 5f;
		skills [0].cooldown [4] = 5f;
		skills [0].cooldown [5] = 7f;

		skills [1].cooldown [1] = 4f;
		skills [1].cooldown [2] = 5f;
		skills [1].cooldown [3] = 5f;
		skills [1].cooldown [4] = 5f;
		skills [1].cooldown [5] = 6f;

		attack_mana [1]=20+20*meteor;
		deffence_mana [1]=20+15*barrier;

		attack_mana [2]=20+10*poison;
		deffence_mana [2]=30+15*shield;

		attack_mana [3]=20+15*fireball;
		deffence_mana [3]=20+10*heal;

		attack_mana [4]=20+15*icegun;
		deffence_mana [4]=25+13*dotheal;

		attack_mana [5]=20+20*helldrop;
		deffence_mana [5]=20+20*reflect;

		foreach (Skill s in skills)
		{
			for(int i=1;i<6;i++)
			s.currentCoolDown[i] = s.cooldown[i] + 1;
		}
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			skill1 ();
		}
		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			skill2 ();
		}
	}
	public void skill1()
	{
		mana = player.gameObject.GetComponent<mve>().getMP();
		if (mana >=attack_mana[attack])
		{
			if (skills[0].currentCoolDown[attack] >= skills[0].cooldown[attack])
			{
				player.gameObject.GetComponent<use_Skill>().attack();
				player.gameObject.GetComponent<mve>().UseSkill1(attack_mana[attack]);
				skills[0].currentCoolDown[attack] = 0;
				//Instantiate(skill_on, player.gameObject.transform.position, Quaternion.identity);
			}
		}
	}
	public void skill2()
	{
		mana = player.gameObject.GetComponent<mve>().getMP();
		if (mana >=deffence_mana[deffence])
		{
			if (skills[1].currentCoolDown[deffence] >= skills[1].cooldown[deffence])
			{
				player.gameObject.GetComponent<use_Skill> ().defend ();
				player.gameObject.GetComponent<mve>().UseSkill1(deffence_mana[deffence]);
				skills[1].currentCoolDown[deffence] = 0;
			}
		}
	}
	private void Update()
	{
		if(skills[0].currentCoolDown[attack] < skills[0].cooldown[attack])
		{
			skills[0].currentCoolDown[attack] += Time.deltaTime;
			skills[0].skillIcon.fillAmount = skills[0].currentCoolDown[attack]/skills[0].cooldown[attack];
		}
		if(skills[1].currentCoolDown[deffence] < skills[1].cooldown[deffence])
		{
			skills[1].currentCoolDown[deffence] += Time.deltaTime;
			skills[1].skillIcon.fillAmount = skills[1].currentCoolDown[deffence]/skills[1].cooldown[deffence];
		}

	}
}

[System.Serializable]
public class Skill
{
	public Image skillIcon;
	public float[] currentCoolDown;//=new float[6];
	public float[] cooldown;//= new float[6];

}