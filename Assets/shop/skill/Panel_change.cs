using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_change : MonoBehaviour {

	// Use this for initialization
	public GameObject at;
	public GameObject df;

	public void att()
	{
		at.SetActive (true);
		df.SetActive (false);
	}
	public void def()
	{
		at.SetActive (false);
		df.SetActive (true);
	}

}
