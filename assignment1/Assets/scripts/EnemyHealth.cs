using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public float Health = 30f;
	public EnemySpawn EnemySpawn;
	public GameObject EnemyDeathParticle;

	// Use this for initialization
	void Start () {
		EnemySpawn = FindObjectOfType <EnemySpawn>();
        EnemyDeathParticle = Resources.Load("Prefab/DeathParticle") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Health == 0f){
			Instantiate(EnemyDeathParticle, transform.position, transform.rotation);
			Destroy (gameObject);
			EnemySpawn.Spawn();
			Debug.Log ("Spawn Activated");
		}
	}

}
