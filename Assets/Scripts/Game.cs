using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Game.cs
/// 
/// This is designed to run the game (runtime scripts)
/// 
/// Author: Gabe Betancourt
/// 
/// </summary>



public class Game : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//base scripts - Any one of these can be expanded to it's own scripting page if it gets too large to keep here
	public class Spawner   //spawn units
	{
		public void initialize()
		{
			print("Spawner Initialized");
		}
		
		//ENEMY CLASS
		public class Enemy
		{
			public int health;
			
			public void initializeEnemy(){
				print("enemy subclass initialized");
			}
			
			
			public class AI
			{
				public void initialize(){
					
						print("AI initialized");
				}
				
				
				public class Drone
				{
					
					public void initialize(){
						print("Drone Initialized");
					}
					
				}
				public Drone drone = new Drone(); //creates class on startup
				
				public class Boss
				{
					
					public void initialize(){
						print("Boss totally Initialized");
					}
					
				}
				public Boss boss = new Boss(); //creates class on startup
				
			}
			public AI ai = new AI(); //creates class on startup
		}
		public Enemy enemy = new Enemy(); //creates class on startup
		
		//SHIP CLASS
		class Ship
		{
			
		}
		
		//POWERUPS CLASS
		class Powerups
		{
			
		}
	}
	public Spawner spawner = new Spawner(); //creates class on startup
	
	public class WeaponSystem	//weapon system for the game
	{
	}
	
	public class Assets		//loads, looks for, and handles assets for the game
	{
		
	}
}


