using UnityEngine;
using System.Collections;

/// <summary>
/// Score system.cs
/// 
/// This script is designed to handle all scoring on a global level for the player
/// 
/// </summary>

public class Score : MonoBehaviour {
	

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public class Systems
	{
		public int globalScore = 0;	//overall top score
		int localScore = 0;		//top score within the game locally
		int currentScore = 0;	//the overall score for the game during a session
		
		public void initialize()
		{
			print("Score System initialized");
		}
		
	}
	
	public Systems system = new Systems();
	
}
