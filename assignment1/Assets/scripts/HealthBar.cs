using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	[SerializeField]
	private float fillAmount;

	[SerializeField]
	private Image sprite;

	public PlayerHealth PlayerHealth;
	public float HealthConvert;

	// Use this for initialization
	void Start () {
		PlayerHealth = FindObjectOfType <PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		Bar();
		fillAmount = HealthConvert;
		HealthConvert = PlayerHealth.Health;
	}

	private void Bar(){
		sprite.fillAmount = fillAmount;
	}
}
