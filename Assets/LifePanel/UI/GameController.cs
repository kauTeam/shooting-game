using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public mve user;
    public GameObject[] ene =new GameObject[2];
	public GameObject win=null;
	public GameObject lose=null;
	public GameObject player =null;

 	// Use this for initialization
    // Update is called once per frame
    void Update()
    {
        Color _fadeColor = new Color(0f, 0f, 0f, 1f);

        //lifepanel.UpdateLife(user.getHP());


        for (int i = 0; i < ene.Length; i++)
        {
            if (ene[i] != null)
            {
                break;
            }
            if (i == ene.LongLength - 1)
            {
				win.SetActive (true);
				Destroy (lose);
               //  Autofade.LoadLevel("scene/main scene", 1, 1, _fadeColor);
            }
        	
        }
        if (player == null)
        {
			lose.SetActive (true);
			Destroy (win);
            //Instantiate(lose, loc.position, loc.rotation);
            //Autofade.LoadLevel("scene/main scene", 1, 1, _fadeColor);
        }
    }
}
