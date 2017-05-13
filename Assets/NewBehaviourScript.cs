using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    // Use this for initialization

    bool state = false;
    void Start()
    {



    }



    // Update is called once per frame

    void Update()
    {
        Invoke("changeScene", 3);
        if (Input.GetKey(KeyCode.Return)||state)
        {
            Application.LoadLevel("start1 scene");

        }

        /* 엔터키를 누르면 main 신을 불러오라는 의미 */
    }
    void changeScene()
    {
        state = true;
    }
}
