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
	
	public class Scores
	{
		public int topScore = 0;	//overall top score
		int localScore = 0;		//current level score until mission complete then reset
		int gameScore = 0;	//the overall score for the game after several levels
		
		public void initialize()
		{
			print("Score System initialized");
		}
		
	}
	
	public Systems system = new Systems();
	
}
