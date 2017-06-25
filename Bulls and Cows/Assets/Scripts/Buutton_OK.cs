using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buutton_OK : MonoBehaviour {
	private GameObject InputBC;

    void Start () {
		InputBC = GameObject.Find ("InputBC");     
    }

    public void ProcessingInputBC() {
		Game game = new Game ();

		if (Game.BC.Length == Game.SizeBC) {
			InputBC.GetComponent<InputField> ().text = null;
			game.CheckingNumbers ();
		} else {
			Debug.Log("Невідповідна кількість символів");     
		}
    }
}