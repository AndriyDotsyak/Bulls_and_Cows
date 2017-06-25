using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_Scenes : MonoBehaviour {

	public void Game_for_two() {
        Application.LoadLevel("Game_for_two");
	}

    public void Registration_Player()
    {
        Application.LoadLevel("Registration_Player");
    }
}
