using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    void Update()
	{
		Invoke ("changeScene", 2);   
        if (Input.GetKey(KeyCode.Return))
        {
            Color _fadeColor = new Color(0f, 0f, 0f, 1f);
            Autofade.LoadLevel("start1 scene", 1, 1, _fadeColor);
        }
        /* 엔터키를 누르면 main 신을 불러오라는 의미 */
    }
	void changeScene()
	{
        Color _fadeColor = new Color(0f, 0f, 0f, 1f);
        Autofade.LoadLevel("start1 scene", 1, 1, _fadeColor);
    }

}
