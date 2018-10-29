using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loops : MonoBehaviour {

int x = 0;
int y = 0;
int z = 41;

		// Use this for initialization
		void Start () {	
			for (int a = 5; a < 10; ++a){
				Debug.Log(a);
			}

			for (int b = 0; b < 20; ++b){
				print("MARCO!");
			}

			for (int c = 20; c > 0; --c){
				print("POLO!");
			}

			while (x < 7){
				print(x);
				print("bottles of beer on the wall!");
				x++;
			}

			while (y <= 32){
				print("riddly diddly!");
				y++;
				y++;
			}

			while (z >= 0){
				print("DOE!");
				z--;
				z--;
			}
		}

		// Update is called once per frame
		void Update () {
			
		}

	
}
