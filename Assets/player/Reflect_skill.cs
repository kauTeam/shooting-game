using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflect_skill : MonoBehaviour {

	public GameObject miss = null;
	public Transform loc = null;
	public Transform pos=null;

	float gage;
	float time;
	// Update is called once per frame

	void Start()
	{
		time = 1.5f+PlayerPrefs.GetInt ("Reflect")*0.2f;
	}


	void Update () {
		Invoke ("destroy", time);
		this.transform.position = pos.position;
	}
	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "enemy_tan") {
			GameObject tan1=Instantiate (miss, loc.position, loc.rotation);
			tan1.GetComponent<tan>().setDamage(tan.gameObject.GetComponent<enemy_tan>().getDamage()/2);
			tan1.GetComponent<tan>().setSpeed(20f);
			Destroy (tan.gameObject);
		}
	}
	void destroy()
	{
		this.gameObject.SetActive(false);
	}

}
