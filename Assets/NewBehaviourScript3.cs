using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour {

    public void gotoDungeon()
    {
		SceneManager.LoadScene("scene/2_monster");
    }
    public void gotoDungeon2()
    {
        SceneManager.LoadScene("scene/1_monster");
    }
    public void gotoTraining()
    {
        SceneManager.LoadScene("scene/Training");
    }
    public void gotoState()
    {
        SceneManager.LoadScene("scene/state scene");
    }
    public void returnMain()
    {
        SceneManager.LoadScene("scene/main scene");
    }
}
