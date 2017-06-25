using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_Name : MonoBehaviour {
    private GameObject Player_1;
    private GameObject Player_2;

    public void OnEndEditPlayer1 () {
        Player_1 = GameObject.Find("Player_1");
        Data_Player.Player_1_Name = Player_1.GetComponent<InputField>().text;
    }

    public void OnEndEditPlayer2() {
        Player_2 = GameObject.Find("Player_2");
        Data_Player.Player_2_Name = Player_2.GetComponent<InputField>().text;
    }
}
