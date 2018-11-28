using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	[SerializeField]
	private float fillAmount;

	[SerializeField]
	private Image sprite;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Bar();
	}

	private void Bar(){
		sprite.fillAmount = fillAmount;
	}
}
