using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_Player : MonoBehaviour {
    public static string Player_1_Name;
    public static string Player_2_Name;

    public static ArrayList Player_1_Value = new ArrayList();
    public static ArrayList Player_2_Value = new ArrayList();

    private GameObject Player_1_Text;
    private GameObject Player_2_Text;

    void Start () {
        Player_1_Text = GameObject.Find("Player_1");
        Player_2_Text = GameObject.Find("Player_2");

        Player_1_Text.GetComponent<Text>().text = Player_1_Name;
        Player_2_Text.GetComponent<Text>().text = Player_2_Name;
    }
}
