using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield_skill : MonoBehaviour {

	public Transform pos=null;
	float gage;
	float time;
	// Update is called once per frame

	void Start()
	{
		gage = (float)(PlayerPrefs.GetInt ("Shild") * 50);
		time = 1.5f+PlayerPrefs.GetInt ("Shild")*0.3f;
        print("start");
    }


    void Update () {
		Invoke ("destroy", time);
		this.transform.position = pos.position;
	}
	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "enemy_tan") {
			
			gage=gage-tan.gameObject.GetComponent<enemy_tan>().getDamage();
			if (gage <= 0) {
                gage = (float)(PlayerPrefs.GetInt("Shild") * 50);
               this.gameObject.SetActive(false);
            }
            Destroy(tan.gameObject);
        }
	}
	void destroy()
	{
        print("destroyed");
        gage = (float)(PlayerPrefs.GetInt("Shild") * 50);
        this.gameObject.SetActive(false);
	}
}
