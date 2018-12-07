using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public float Health = 30f;
	public GameObject EnemyDeathParticle;

	// Use this for initialization
	void Start () {
        EnemyDeathParticle = Resources.Load("Prefab/DeathParticle") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health == 0f){
			Instantiate(EnemyDeathParticle, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}

}
