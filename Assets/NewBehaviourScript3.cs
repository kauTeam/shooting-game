using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour {

    Color _fadeColor = new Color(0f, 0f, 0f, 1f);
    public void gotoDungeon()
    {
        Autofade.LoadLevel("scene/Round1/1-1", 1, 1, _fadeColor);
    }
    public void gotoDungeon2()
    {
        Autofade.LoadLevel("scene/2_monster part2", 1, 1, _fadeColor);
    }
    public void gotoTraining()
    {
        SceneManager.LoadScene("scene/Training");
    }
    public void gotoState()
    {
        SceneManager.LoadScene("scene/states");
    }
	public void gotoShop()
	{
		SceneManager.LoadScene("scene/shop");
	}
    public void returnMain()
    {
        SceneManager.LoadScene("scene/main scene");
    }
    public void returnfadeMain()
    {
        Autofade.LoadLevel("scene/main scene", 1, 1, _fadeColor);
    }
    public void gostory1()
    {
        SceneManager.LoadScene("scene/storyboard");
    }
    public void gostory2()
    {
        SceneManager.LoadScene("scene/storyboard2");
    }
    public void reset()
	{
		PlayerPrefs.SetInt ("lv",1);
		PlayerPrefs.SetInt ("exp", 1);
		PlayerPrefs.SetInt ("point", 1);

		PlayerPrefs.SetFloat ("Damage", 1f);
		PlayerPrefs.SetFloat ("Max_Damage", 5f);
		PlayerPrefs.SetFloat ("attack_speed", 1f);
		PlayerPrefs.SetFloat ("Max_attack_speed", 5f);
		PlayerPrefs.SetFloat ("Mana", 1f);
		PlayerPrefs.SetFloat ("Max_Mana", 5f);
		PlayerPrefs.SetFloat ("Mana_re", 1f);
		PlayerPrefs.SetFloat ("Max_Mana_re", 5f);
		PlayerPrefs.SetFloat ("Hp", 1f);
		PlayerPrefs.SetFloat ("Max_Hp", 5f);

		PlayerPrefs.SetInt ("coin", 1000);
		PlayerPrefs.SetInt ("soul", 0);

		PlayerPrefs.SetInt ("attack", 1);
		PlayerPrefs.SetInt ("defence", 1);

		PlayerPrefs.SetInt ("Metemor", 1);
		PlayerPrefs.SetInt ("Poison", 1);
		PlayerPrefs.SetInt ("FireBall", 1);
		PlayerPrefs.SetInt ("IceGun", 1);
		PlayerPrefs.SetInt ("HellDrop", 1);

		PlayerPrefs.SetInt ("Barrier", 1);
		PlayerPrefs.SetInt ("Shild", 1);
		PlayerPrefs.SetInt ("Heal", 1);
		PlayerPrefs.SetInt ("DotHeal", 1);
		PlayerPrefs.SetInt ("Reflect", 1);

	}
}
