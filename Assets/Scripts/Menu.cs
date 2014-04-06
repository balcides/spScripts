using UnityEngine;
using System.Collections;

/// <summary>
/// Menu.cs
/// 
/// This script is deisgned to run the menus and start on startup
/// This is meant to attach to runGame
/// </summary>
/// 
///  

[RequireComponent (typeof (LevelSelect))]	//require the level select script to load with this


//lselect levelSelect = collision.gameObject.GetComponent<levelSelect>();	

public class Menu : MonoBehaviour {
	
	private LevelSelect ls; 				//loading level select class
	
	void Awake(){
		
		ls = GetComponent<LevelSelect>(); 	//initializing scripts (make sure it's attached)
		ls.gameOver();						//Here Im calling gameOver
		ls.missionComplete();				//Here Im calling MissionComplete as part af a class test
		ls.levelSelection(); 				//loads the levels selection menu
		ls.levels.rounds(); 				//level rounds initialized	
		ls.levels.bonus();					//bonus rounds added
		
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

//adding a test comment in case I want to edit something here in Github
