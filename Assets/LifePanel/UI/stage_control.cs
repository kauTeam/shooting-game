using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stage_control : MonoBehaviour {


	Color _fadeColor = new Color(0f, 0f, 0f, 1f);
	public int round;
	public int[] level = new int[6];
	public GameObject[] button = new GameObject[6];
	public void Update()
	{
		if (!PlayerPrefs.HasKey ("clear")) {
			PlayerPrefs.SetInt ("clear", 11);
		}
		int clear = PlayerPrefs.GetInt ("clear");
		for (int i = 0; i < 6; i++) {
			if (clear >= level [i]) {
				button [i].SetActive (true);
			}
			else if (clear < level [i]) {
				button [i].SetActive (false);
			}
		}
	}

	// Use this for initialization
	public void go_1()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-1", 1, 1, _fadeColor);
	}
	public void go_2()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-2", 1, 1, _fadeColor);
	}
	public void go_3()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-3", 1, 1, _fadeColor);
	}
	public void go_4()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-4", 1, 1, _fadeColor);
	}
	public void go_5()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-5", 1, 1, _fadeColor);
	}
	public void go_6()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-6", 1, 1, _fadeColor);
	}
}
