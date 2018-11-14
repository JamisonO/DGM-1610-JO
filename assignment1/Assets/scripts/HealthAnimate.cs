using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	public PlayerHealth PlayerHealth;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		switch (PlayerHealth.Health)
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
		}
	}
}
