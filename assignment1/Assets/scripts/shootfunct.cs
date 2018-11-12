using System.Collections;
using UnityEngine;

public class shootfunct : MonoBehaviour {

	// Shoot Variables
	public Transform FirePoint;
	public GameObject Projectile;

	void Start(){
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;
	}

	//Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0))
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
	}
}
