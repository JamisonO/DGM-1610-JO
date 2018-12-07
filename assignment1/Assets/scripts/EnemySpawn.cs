using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	public GameObject EnemyPatrol; 
	public GameObject SpawnPoint;            

	// Use this for initialization
	void Start () {
		
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
		 Instantiate (EnemyPatrol);
	}
}
