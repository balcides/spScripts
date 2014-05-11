using UnityEngine;
using System.Collections;

/// <summary>
/// 
/// Spawner.cs
/// 
/// Script to control the spawner 
/// 
/// </summary>

public class Spawner : MonoBehaviour {
	
	public enum Spawn {Enemy, PlayerShip, Powerup};
	public Spawn spawnSelection;
	
	public GameObject[] enemiesGO;
	public GameObject[] powerupGO;
	public GameObject playerShipGO;
	
	public Color gizmoColor;
	public float gizmoScale;
	
	Spawn spawnType (Spawn spawning)
    {
        if(spawning == Spawn.Enemy){ 				enemy(); 	}
        else if(spawning == Spawn.PlayerShip){ 		ship(); 	}
		else if(spawning == Spawn.Powerup){ 		powerup(); 	}
		else{}
		
        return spawning;     
    }

	// Use this for initialization
	void Start () {
		spawnType(spawnSelection);	//initialize controls
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//supposed to spew enemies from the array
	public void enemy(){
		print("Enemy spawn initialized");
		//Transform enemy0 = Instantiate(enemiesGO[0]) as Transform;
	}
	
	//supposed to spew ship player from the array
	public void ship(){
		print("Player spawn initialized");
		//Transform playerGO = Instantiate(playerShipGO) as Transform;
	}
	
	//supposed to spew the powerups from the array
	public void powerup(){
		print("Power Up spawn initialized");
		//Transform powerup0 = Instantiate(powerupGO[0]) as Transform;
	}
	
	//Diplays the Spawner
	void OnDrawGizmos(){
		gizmoColor.a = 255;
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere(transform.position, gizmoScale);
	}
}
