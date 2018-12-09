using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

	public float Damage;
	public EnemyHealth EnemyHealth;
	public float Speed;
	public Rigidbody2D Player;
	public GameObject ProjectileParticle;

	// Use this for initialization
	void Start () {
		EnemyHealth = FindObjectOfType <EnemyHealth>();
		Player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
		ProjectileParticle = Resources.Load("Prefab/projectile particle") as GameObject;
		if(Player.transform.localScale.x < 0)
			Speed = -Speed;	

	}

	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}
	
	void OnCollisionEnter2D(Collision2D other){
		Instantiate(ProjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}
	
}
