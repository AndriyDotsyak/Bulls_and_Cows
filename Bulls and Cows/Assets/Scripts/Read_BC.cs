using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_BC : MonoBehaviour {
    public InputField InputBC;

    public void OnEndEditBC()
    {
        Buutton_OK.BC = InputBC.text;
    }
}
