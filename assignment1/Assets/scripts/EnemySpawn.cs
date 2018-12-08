using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	
	public GameObject EnemyPatrol; 
	public GameObject EnemyPatrol2;
	public GameObject SpawnPoint; 

	GameObject[] EnemyInv = new GameObject[2];         

	// Use this for initialization
	void Start () {
		EnemyInv[0] = EnemyPatrol;
		EnemyInv[1] = EnemyPatrol2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Spawn()
    {
        StartCoroutine("SpawnCo");
    }

	public IEnumerator SpawnCo()
    {
         yield return new WaitForSeconds(5.0f);
		 int EnemyIndex = Random.Range (0, EnemyInv.Length);
		 GameObject inst = (GameObject)Instantiate (EnemyInv[EnemyIndex]);
	}
}
