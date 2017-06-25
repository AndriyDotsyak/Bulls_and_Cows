using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_BC : MonoBehaviour {
    private GameObject InputBC;

    public void OnEndEditBC()
    {
        InputBC = GameObject.Find("InputBC");
        Game.BC = InputBC.GetComponent<InputField>().text;
    }
}
