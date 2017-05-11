using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public mve user;
    public LifePanel lifepanel;
	public GameObject ene1 =null;
	public GameObject ene2 =null;
	public GameObject player =null;
	public GameObject lose = null;
	public GameObject win = null;

	public Transform loc = null;
	// Use this for initialization
    // Update is called once per frame
    void Update()
    {
        lifepanel.UpdateLife(user.getLife());
		if (ene1 == null && ene2 == null) {
			Instantiate (win, loc.position, loc.rotation);
		}
		if (player== null) {
			Instantiate (lose, loc.position, loc.rotation);
		}

    }
}
