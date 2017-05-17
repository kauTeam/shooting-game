using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TrainingToMain : MonoBehaviour {

    public void scenechange1()
    {
        SceneManager.LoadScene("main scene");
    }
}
