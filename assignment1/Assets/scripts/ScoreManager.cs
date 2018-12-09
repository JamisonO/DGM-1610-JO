using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public static int Score;
	public int WinScore;
	public Text Wintext;
	public Text GameOver;
	Text ScoreText;
	public LevelManager LevelManager;

	void Awake(){
		Time.timeScale = 1;
	}

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();

		ScoreText = GetComponent<Text>();

		Score = 0;

		Wintext.GetComponent<Text>().enabled = false;
		GameOver.GetComponent<Text>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Score < 0)
			Score = 0;
		ScoreText.text = "Score: " + Score + "/300";		

		//If player wins, display win text
		if(Score >= WinScore ){
			print("Win Score Reached = " + Score);
			Wintext.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		//If player loses, display game over
		if(LevelManager.Lives == 0) {
			GameOver.GetComponent<Text>().enabled = true;
			Time.timeScale = 0;
		}

		// If player hits the Escape key return to start menu
		if(Input.GetKeyDown(KeyCode.Escape)){
			SceneManager.LoadScene("Game Menu");
		}

	}

	public static void AddPoints (int PointsToAdd){
		
		
		Score += PointsToAdd;

		
	}


}
