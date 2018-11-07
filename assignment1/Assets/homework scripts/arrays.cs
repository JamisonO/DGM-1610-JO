using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour {

	string[] Inventory = new string[5];
	int [] Ledger = new int[]{25, 62, 3, 79, 1};
	float [] Floatarray = new float[]{2.3f, 6.9f, 1.8f, 9.3f};
	double [] Doublearray = new double[]{7.6d, 3.7d, 2.1d, 8.4d};
	bool [] Switchstate = new bool[]{false, true, false, false, true};

	// Use this for initialization
	void Start () {

		Inventory[0] = "Health Potion";
		Inventory[1] = "Rope";
		Inventory[2] = "Water Skin";
		Inventory[3] = "Sword";
		Inventory[4] = "Crossbow";

		foreach (string item in Inventory){
			print("Using" + item);
		}


	}

	
	
	// Update is called once per frame
	void Update () {
		
	}
}

