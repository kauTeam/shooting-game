using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    // Use this for initialization

    void Start()
    {



    }



    // Update is called once per frame

    void Update()
    {



        if (Input.GetKey(KeyCode.Return))
        {

            Application.LoadLevel("start1 scene");

        }

        /* 엔터키를 누르면 main 신을 불러오라는 의미 */


    }
}
