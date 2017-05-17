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
    // Use this for initialization
    void Start () {
        foreach (Skill s in skills)
        {
            s.currentCoolDown = s.cooldown + 1;
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
		if (mana >=30)
		{
			if (skills[0].currentCoolDown >= skills[0].cooldown)
			{
                player.gameObject.GetComponent<use_Skill>().attack();
				player.gameObject.GetComponent<mve>().UseSkill1(30);
				skills[0].currentCoolDown = 0;
                //Instantiate(skill_on, player.gameObject.transform.position, Quaternion.identity);
            }
		}
	}
	public void skill2()
	{
		mana = player.gameObject.GetComponent<mve>().getMP();
		if (mana >=50)
		{
			if (skills[1].currentCoolDown >= skills[1].cooldown)
			{
				player.gameObject.GetComponent<use_Skill> ().defend ();
				player.gameObject.GetComponent<mve>().UseSkill1(50);
				skills[1].currentCoolDown = 0;
			}
		}
	}
    private void Update()
    {
        foreach(Skill s in skills)
        {
            if(s.currentCoolDown < s.cooldown)
            {
                s.currentCoolDown += Time.deltaTime;
                s.skillIcon.fillAmount = s.currentCoolDown/s.cooldown;
            }
        }

    }
}

[System.Serializable]
public class Skill
{
    public float cooldown;
    public Image skillIcon;
    [HideInInspector]
    public float currentCoolDown;

}