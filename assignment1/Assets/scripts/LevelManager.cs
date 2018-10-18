using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	// Particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty on Death
	public int PointPenaltyOnDeath;

	//Store Gravity Value
	private float GravityStore;

	//Use this for initialization
	void Start () {
		Player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Hide Player
		//Player.isKinematic = false;
		if(Player != null)
		{
		Player.GetComponent<Renderer> ().enabled = false;
		}
		//Generate Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Match Players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show player
		//Player.isKinematic = true;
		Player.GetComponent<Renderer> ().enabled = true;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Gravity restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Debug Message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Spawn Particle
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}
