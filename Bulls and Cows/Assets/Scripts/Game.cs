using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public static ArrayList RandomBC = new ArrayList();
    public static int SizeBC = 4;
    public static bool Player_1;
    public static bool Player_2;
	public static string BC;

    private static GameObject Active_1;
	private static GameObject Active_2;
	private static GameObject NotActive_1;
	private static GameObject NotActive_2;



	public static int B;
	public static int C;
	private static int Index_1;
	private static int Index_2;

	private static GameObject Player_1_OUT;
	private static GameObject Player_2_OUT;
    private static GameObject End;

    void Start () {
		Player_1_OUT = GameObject.Find ("Player_1_OUT");
		Player_2_OUT = GameObject.Find ("Player_2_OUT");

        End = GameObject.Find("End");

        Rand();

		Active_1 = GameObject.Find("Active_1");
		Active_2 = GameObject.Find("Active_2");
		NotActive_1 = GameObject.Find("NotActive_1");
		NotActive_2 = GameObject.Find("NotActive_2");

		Active_1.active = true;
		Active_2.active = false;
		NotActive_1.active = false;
		NotActive_2.active = true;

		Player_1 = true;
		Player_2 = false;

		Index_1 = 0;
		Index_2 = 0;
    }
		
	private void Rand() {
		for (int i = 0; i < 6; i++) {
			int iNumber = Random.Range (0, 10);

			if (!RandomBC.Contains(iNumber)) {
				RandomBC.Add(iNumber);
			} else {
				i--;
			}
		}

		for (int i = 0; i < SizeBC; i++)
		{
			Debug.Log(i +". " +RandomBC[i]);
		}
	}

	public void CheckingNumbers() {
		B = 0;
		C = 0;

		if (Player_1 == true && Player_2 == false){
			Active_1.active = false;
			Active_2.active = true;
			NotActive_1.active = true;
			NotActive_2.active = false;

			Player_1 = false;
			Player_2 = true;

			Data_Player.Player_1_Value.Add(BC);


			for (int i = 0; i < SizeBC; i++) {
				if ((RandomBC[i].ToString() == BC[i].ToString())) {
					B++;
				}

				for (int j = 0; j < SizeBC; j++) {
					if (RandomBC[i].ToString() == BC[j].ToString()) {
						C++;
					}
				}
			}

			C = C - B;

			Player_1_OUT.GetComponent<Text>().text += Index_1+1 +". " +BC +" - " +B +"B" +C +"C" +"\n";

            if (B == SizeBC) {
                //End.active = true;
               
                End.GetComponent<Text>().text = "Wins  " + Data_Player.Player_1_Name;
            }

			BC = null;
			Index_1++;

		} else {
			
			Active_1.active = true;
			Active_2.active = false;
			NotActive_1.active = false;
			NotActive_2.active = true;

			Player_1 = true;
			Player_2 = false;

			Data_Player.Player_2_Value.Add(BC);

			for (int i = 0; i < SizeBC; i++) {
				if ((RandomBC[i].ToString() == BC[i].ToString())) {
					B++;
				}

				for (int j = 0; j < SizeBC; j++) {
					if (RandomBC[i].ToString() == BC[j].ToString()) {
						C++;
					}
				}
			}

			C = C - B;

			Player_2_OUT.GetComponent<Text>().text += Index_2+1 +". " +BC +" - " +B +"B" +C +"C" +"\n";

            if (B == SizeBC) {
                //End.active = true;

                End.GetComponent<Text>().text = "Wins  " + Data_Player.Player_2_Name;
            }

            BC = null;
			Index_2++;
		}  
	}
}