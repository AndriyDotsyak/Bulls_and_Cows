using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buutton_OK : MonoBehaviour {
    public InputField InputBC;
    public static string BC;
    public GameObject Active_1;
    public GameObject Active_2;
    public GameObject NotActive_1;
    public GameObject NotActive_2;

    void Start () {
        Game.Player_1 = true;
        Game.Player_2 = false;

        Active_1.active = true;
        Active_2.active = false;
        NotActive_1.active = false;
        NotActive_2.active = true;
    }

    public void ProcessingInputBC() {
        if (BC.Length == Game.SizeBC) {
            Debug.Log(BC);
            InputBC.text = null;

            if (Game.Player_1 == true && Game.Player_2 == false)
            {
                Active_1.active = false;
                Active_2.active = true;
                NotActive_1.active = true;
                NotActive_2.active = false;

                Debug.Log("2");
                Game.Player_1 = false;
                Game.Player_2 = true;
            } else {
                Active_1.active = true;
                Active_2.active = false;
                NotActive_1.active = false;
                NotActive_2.active = true;

                Debug.Log("1");
                Game.Player_1 = true;
                Game.Player_2 = false;
            } 
        } else {
            Debug.Log("Невідповідна кількість символів");     
        }
    }
}
