using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

     public class LevelManager : MonoBehaviour

     {
     
         public GameObject CurrentCheckPoint;
         //public GameObject Player2;
         public GameObject Player;
         private Rigidbody2D PlayerRb;
         private Collider2D PlayerCollider;
         private Renderer playersRender;
         public PlayerHealth PlayerHealth;
         public float Lives = 3;
         public Slider LivesBar;
         // Particles
         public GameObject DeathParticle;
         public GameObject RespawnParticle;
         //Respawn Delay
         public float RespawnDelay;
         //Point Penalty on Death
         public int PointPenaltyOnDeath;
         //Store Gravity Value
         private float GravityStore;

         private bool respawnIsRunning;

         //Use this for initialization
         void Start()
         {
             PlayerRb = Player.GetComponent<Rigidbody2D>();
             playersRender = Player.GetComponent<Renderer>();
             PlayerCollider = Player.GetComponent<Collider2D>();
             print(playersRender);
             PlayerHealth = FindObjectOfType <PlayerHealth>();
         }

         void Update () {
             LivesBar.value = Lives;
         }
     
         public void RespawnPlayer()
         {
             if(!respawnIsRunning)
             {
             StartCoroutine("RespawnPlayerCo");
             }
         }
     
         public IEnumerator RespawnPlayerCo()
         {
             respawnIsRunning = true;

             Lives -= 1;

             //Hide Player
             playersRender.enabled = false;    
             PlayerCollider.enabled = false;

             //Generate Death Particle
             Instantiate(DeathParticle, Player.transform.position, Player.transform.rotation);

             //Gravity Reset
             GravityStore = PlayerRb.gravityScale;
             PlayerRb.gravityScale = 0f;
             PlayerRb.velocity = Vector2.zero;
             yield return new WaitForSeconds(RespawnDelay);

             //Gravity restore   
             PlayerRb.gravityScale = GravityStore;
             
             //Instantiate particles
             Instantiate(RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
             
             //Respawn player at the current check point
             PlayerHealth.Health = 100;
             Player.transform.position = new Vector3 (CurrentCheckPoint.transform.position.x, CurrentCheckPoint.transform.position.y, CurrentCheckPoint.transform.position.z);
             playersRender.enabled = true;
             PlayerCollider.enabled = true;
             Debug.Log("Player Respawned");
             respawnIsRunning = false;
         }

         public void AddLife (float LifetoAdd){
		
		 Lives += LifetoAdd;

	     }
     }
