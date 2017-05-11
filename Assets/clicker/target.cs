using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider tan)
	{
		if (tan.tag == "user_tan") {
			Destroy (tan.gameObject);
		}
	}
}

