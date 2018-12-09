using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public float Damage = 10f;
	public float Health = 30f;
	public EnemySpawn EnemySpawn;
	public GameObject EnemyDeathParticle;
	public GameObject AmmoPU;
	public GameObject HealthPU;
	public GameObject InvincibilityPU;
	public GameObject LifePU;
	public GameObject SpeedPU;
	public GameObject coin;
	

	// Use this for initialization
	void Start () {
		EnemySpawn = FindObjectOfType <EnemySpawn>();
        EnemyDeathParticle = Resources.Load("Prefab/DeathParticle") as GameObject;
		AmmoPU = Resources.Load("Prefab/AmmoPU") as GameObject;
		HealthPU = Resources.Load("Prefab/HealthPU") as GameObject;
		InvincibilityPU = Resources.Load("Prefab/InvincibilityPU") as GameObject;
		LifePU = Resources.Load("Prefab/LifePU") as GameObject;
		SpeedPU = Resources.Load("Prefab/SpeedPU") as GameObject;
		coin = Resources.Load("Prefab/coin") as GameObject;
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Projectile"){
			Health -= Damage;
		}
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] PUInv = {AmmoPU, HealthPU, InvincibilityPU, LifePU, SpeedPU};

		if (Health <= 0){
			Health = 0;
		}

		if(Health == 0f){
			Instantiate(EnemyDeathParticle, transform.position, transform.rotation);
			Destroy (gameObject);
			int PUIndex = Random.Range (0, PUInv.Length);
		 	GameObject inst = ((GameObject)Instantiate (PUInv[PUIndex], transform.position, transform.rotation));
			Instantiate(coin, transform.position, transform.rotation);
			Instantiate(coin, transform.position, transform.rotation);
			EnemySpawn.Spawn();
			Debug.Log ("Spawn Activated");
			
		}
	}

}
