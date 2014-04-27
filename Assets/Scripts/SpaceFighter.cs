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

public class SpaceFighter : MonoBehaviour {
	
	private	GameObject GlobalGO = null;
	
	// Use this to initialize any variables or game state before the game starts. 
	void Awake(){
		
		//check attached gameObjects
		GlobalGO = GameObject.Find("Global");						//check that this script is attached to a game object named "Global"
	}
	
	// Use this for initialization
	void Start () {
			
			//checks if this is with the game object
			if(GlobalGO == null){
			Debug.LogError("Make sure Menu.cs is attached to an empty gameObject named 'GlobalGO', or make one and assign");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
