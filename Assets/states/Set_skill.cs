using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_skill : MonoBehaviour {

	public void attack1()
	{
		PlayerPrefs.SetInt ("attack", 1);
	}
	public void attack2()
	{
		PlayerPrefs.SetInt ("attack", 2);
	}
	public void attack3()
	{
		PlayerPrefs.SetInt ("attack", 3);
	}
	public void attack4()
	{
		PlayerPrefs.SetInt ("attack", 4);
	}
	public void attack5()
	{
		PlayerPrefs.SetInt ("attack", 5);
	}
	public void defence1()
	{
		PlayerPrefs.SetInt ("defence", 1);
	}
	public void defence2()
	{
		PlayerPrefs.SetInt ("defence", 2);
	}
	public void defence3()
	{
		PlayerPrefs.SetInt ("defence", 3);
	}
	public void defence4()
	{
		PlayerPrefs.SetInt ("defence", 4);
	}
	public void defence5()
	{
		PlayerPrefs.SetInt ("defence", 5);
	}
}
