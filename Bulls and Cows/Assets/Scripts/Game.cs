using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {
    public static int[] RandomBC = new int[10];
    public static int SizeBC = 4;
    public static bool Player_1;
    public static bool Player_2;
    

    void Start () {
        Rand();
    }

    private void Rand () { 
        for (int i = 0; i < SizeBC; i++) {
            int TempRandomBC = Random.Range(0, 10);
            RandomBC[i] = TempRandomBC;
        }
        for (int i = 0; i < SizeBC; i++)
        {
            Debug.Log(i +". " +RandomBC[i]);
        }
    }
}
