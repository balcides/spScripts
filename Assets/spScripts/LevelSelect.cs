using UnityEngine;
using System.Collections;
/// <summary>
/// Level select.cs
/// 
/// This will setup any specifics with the level loading, game over, mission complete, etc.
/// </summary>
/// 
/// 



public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// runs all the gamer over events
	public static void gameOver(){
		print ("gameover working");
	}
	
	//runs the entire mission complete sequence including score tally, messages, animation, sound, events after all levels complete
	public static void missionComplete(){
	}
	
	//testing classes and referencing
	public void doThis(){
		print ("this is working");
	}
}
