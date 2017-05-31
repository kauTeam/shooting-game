using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shild : MonoBehaviour {

	// Use this for initialization
	float gage;
	float time;
	// Update is called once per frame


	void Start()
	{
		gage = 30f+PlayerPrefs.GetInt ("Shild_gage")*60f;
		time = 2f+PlayerPrefs.GetInt ("Barrier")*0.2f;
	}


	void Update () {
		Invoke ("destroy", time);
	}
	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "enemy_tan") {
			Destroy (tan.gameObject);
			gage=gage-tan.gameObject.GetComponent<enemy_tan>().getDamage();
			if (gage <= 0) {
				Destroy (this.gameObject);
			}
		}
	}
	void destroy()
	{
		Destroy (this.gameObject);
	}
}
