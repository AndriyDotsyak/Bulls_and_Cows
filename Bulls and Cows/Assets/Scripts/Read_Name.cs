using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_Name : MonoBehaviour {
    public InputField Player_1;
    public InputField Player_2;

    public void OnEndEditPlayer1 () {
        Data_Player.Player_1_Name = Player_1.text;
    }

    public void OnEndEditPlayer2() {
        Data_Player.Player_2_Name = Player_2.text;
    }
}
