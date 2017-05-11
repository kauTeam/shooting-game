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
		if (PlayerPrefs.HasKey ("Shild_gage")) {
			gage = PlayerPrefs.GetFloat ("Shild_gage");
		} else {
			gage = 100f;
		}
		if (PlayerPrefs.HasKey ("Shild_time")) {
			time = PlayerPrefs.GetFloat ("Shild_time");
		} else {
			time = 3f;
		}
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
