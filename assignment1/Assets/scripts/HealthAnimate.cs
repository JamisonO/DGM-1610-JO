using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public int health = 80;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch (health)
		{
		case 50:
			//animation 3
			Debug.Log("Slightly Injured");
			break;
		case 20:
			//animation 2
			Debug.Log("Fairly Injured");
			break;
		case 5:
			//animation 1
			Debug.Log("Critically Injured");
			break;
		default:
			//
			Debug.Log("Barely Alive");
			break;
		}
	}
}
