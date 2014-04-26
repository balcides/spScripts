using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Menu.cs
/// 
/// This script is deisgned to run the menus and start on startup
/// This is meant to attach to runGame
///
/// </summary>



[RequireComponent (typeof (LevelSelect))]	//require the level select script to load with this
[RequireComponent (typeof (Score))]			//require score system


public class Menu : MonoBehaviour {
	
	private LevelSelect levelSelect; 				//loading level select class
	private Score score; 					//loading level select class
	int iScore;
	
	void Awake(){
		
		levelSelect = GetComponent<LevelSelect>(); 	//initializing scripts (make sure it's attached)
		score = GetComponent<Score>(); 		//initializing scripts (make sure it's attached)
		
		levelSelect.gameOver();						//Here Im calling gameOver
		levelSelect.missionComplete();				//Here Im calling MissionComplete as part af a class test
		levelSelect.levels.rounds(); 				//level rounds initialized	
		levelSelect.levels.bonus();					//bonus rounds added
		
		score.Scores.initialize();			//initializes score system
		
		iScore = score.Scores.gameScore;
		print(score.Scores.gameScore);
                print(score.Scores.levelScore);
                print(score.Scores.topScore);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
	
	// Scripts the Start menu and anything that has to get going when the game starts
	void startMenu(){
	}
	
}


