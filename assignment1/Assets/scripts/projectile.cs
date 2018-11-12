using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

	public float Speed;
	public Rigidbody2D Player;

	public GameObject EnemyDeathParticle;

	public GameObject ProjectileParticle;

	public int PointsForKill;

	// Use this for initialization
	void Start () {
		Player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
		EnemyDeathParticle = Resources.Load("Prefab/DeathParticle") as GameObject;
		ProjectileParticle = Resources.Load("Prefab/projectile particle") as GameObject;
		if(Player.transform.localScale.x < 0)
			Speed = -Speed;	

	}

	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeathParticle, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}
	}

	void OnCollisionEnter2d(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}

}
