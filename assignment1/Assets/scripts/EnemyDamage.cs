using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public PlayerHealth PlayerHealth;
	public float Damage = 10f;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}

	void OnTriggerEnter2D(Collider2D other){
			if(other.name == "Player") {
				PlayerHealth.Health -= Damage;
			}
		}

	// Update is called once per frame
	void Update () {

	}

	// coroutine for invincibility pickup

	public void DamageStop()
    {
        StartCoroutine("DamageStopCo");
    }

	public IEnumerator DamageStopCo()
    {
		 Damage = 0;
         yield return new WaitForSeconds(10.0f);
		 Damage = 10;
	}	

}

