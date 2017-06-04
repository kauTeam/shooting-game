using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result_button_control : MonoBehaviour {


    Color _fadeColor = new Color(0f, 0f, 0f, 1f);

	public int round;
	public int level;
    // Use this for initialization
	public void load_next()
	{
		if (level != 6) {
			Autofade.LoadLevel ("scene/Round" + round.ToString () + "/" + round.ToString () + "-" + (level + 1).ToString (), 1, 1, _fadeColor);
		} else {
			Autofade.LoadLevel ("scene/Round" + (round+1).ToString () + "/" + (round+1).ToString () + "-1", 1, 1, _fadeColor);
				
		}
    }
	public void load_lv_select()
	{
		Autofade.LoadLevel("scene/StoryBoard/storyboard"+round.ToString(), 1, 1, _fadeColor);
    }
	public void load_now()
	{
		Autofade.LoadLevel("scene/Round"+round.ToString()+"/"+round.ToString()+"-"+level.ToString(), 1, 1, _fadeColor);

    }
}
