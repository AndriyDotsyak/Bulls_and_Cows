using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_Player : MonoBehaviour {
    public static string Player_1_Name;
    public static string Player_2_Name;
    public Text Player_1_Text;
    public Text Player_2_Text;

    void Start () {
        Player_1_Text.text = Player_1_Name;
        Player_2_Text.text = Player_2_Name;
    }
	
	void Update () {
		
	}
}
