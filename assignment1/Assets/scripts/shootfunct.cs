using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class shootfunct : MonoBehaviour {

	public Slider Bar;

	// Shoot Variables
	public float Ammo = 20f;
	public Transform FirePoint;
	public GameObject Projectile;

	void Start(){
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;
	}

	//Update is called once per frame
	void Update () {

		Bar.value = Ammo;

		if(Input.GetKeyDown(KeyCode.Mouse0)){
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);
			Ammo -= 1;	
		}

		if (Ammo <= 0){
			Ammo = 0;
		}

		if(Ammo == 0f){
			Projectile.SetActive(false);
		}

		else {
			Projectile.SetActive(true);
		}
	}

	public void AddAmmo (float AmmotoAdd){
		
		Ammo += AmmotoAdd;

	}

}
