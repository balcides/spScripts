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
	
	private LevelSelect ls; 				//loading level select class
	private Score score; 					//loading level select class
	int iScore;
	
	void Awake(){
		
		ls = GetComponent<LevelSelect>(); 	//initializing scripts (make sure it's attached)
		score = GetComponent<Score>(); 		//initializing scripts (make sure it's attached)
		
		ls.gameOver();						//Here Im calling gameOver
		ls.missionComplete();				//Here Im calling MissionComplete as part af a class test
		ls.levels.rounds(); 				//level rounds initialized	
		ls.levels.bonus();					//bonus rounds added
		
		score.system.initialize();			//initializes score system
		
		iScore = score.system.globalScore;
		
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


