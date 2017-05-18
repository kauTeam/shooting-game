using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    // Use this for initialization

    void Start()
    {



    }



    // Update is called once per frame

    void Update()
	{
		Invoke ("changeScene", 2);   
        if (Input.GetKey(KeyCode.Return))
        {

			SceneManager.LoadScene("start1 scene");
        }
        /* 엔터키를 누르면 main 신을 불러오라는 의미 */
    }
	void changeScene()
	{
		SceneManager.LoadScene("start1 scene");
	}

}
