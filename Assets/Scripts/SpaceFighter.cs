using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// SpaceFighter.cs
/// 
/// This script is deisgned to run the menus and start on startup
/// This is meant to attach to a unity scene file named "runGame"
/// to start the game with and attach to a gameObject named "Global"
///
/// </summary>

[RequireComponent (typeof (Menu))]					//require Menu
[RequireComponent (typeof (Inputs))]					//require Input
[RequireComponent (typeof (Screensize))]					//require Screensize
[RequireComponent (typeof (Game))]					//require Game

public class SpaceFighter : MonoBehaviour {
	
	private	GameObject GlobalGO = null;
	private Game game;
	
	// Use this to initialize any variables or game state before the game starts. 
	void Awake(){
		
		//check attached gameObjects
		GlobalGO = GameObject.Find("Global");						//check that this script is attached to a game object named "Global"
		
		game = GetComponent<Game>(); 	//initialize game
		
	}
	
	// Use this for initialization
	void Start () {
			
			//checks if this is with the game object
			if(GlobalGO == null){
			Debug.LogError("Make sure Menu.cs is attached to an empty gameObject named 'GlobalGO', or make one and assign");
			}else{}
			
			//initilalize AI
			game.spawner.initialize();
			game.spawner.enemy.initializeEnemy();
			game.spawner.enemy.ai.initialize();
			game.spawner.enemy.ai.drone.initialize();
			game.spawner.enemy.ai.boss.initialize();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
