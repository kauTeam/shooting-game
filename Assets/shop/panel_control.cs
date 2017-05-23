using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel_control : MonoBehaviour {


	public GameObject soul;
	public GameObject stat;
	public GameObject skill;
	// Use this for initialization

	public void skill_on()
	{
		soul.SetActive (false);
		stat.SetActive (false);
		skill.SetActive (true);
	}
	public void stat_on()
	{
		soul.SetActive (false);
		stat.SetActive (true);
		skill.SetActive (false);

	}
	public void soul_on()
	{
		soul.SetActive (true);
		stat.SetActive (false);
		skill.SetActive (false);

	}
}
