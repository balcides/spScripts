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




//lselect levelSelect = collision.gameObject.GetComponent<levelSelect>();	

public class Menu : MonoBehaviour {
	
	private LevelSelect levelSelect;
	private LevelSelect lss;
	
	void Awake(){
		 levelSelect = GetComponent<LevelSelect>();
	}

	// Use this for initialization
	void Start () {

		LevelSelect.gameOver();		//this was using a public static class
		levelSelect.doThis(); //this was using getComponent but not set as an istance
		
		//LevelSelect ls = new LevelSelect(); //this is discouraged
		lss = this.gameObject.AddComponent("LevelSelect") as LevelSelect; //this works instead of "new"
		
		lss.doThis();	// uses the addComponent
		//ls.doThis();	// uses the "new"
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	// Scripts the Start menu and anything that has to get going when the game starts
	void startMenu(){
	}
	
}

// end of script. Testing revision control

/*
public class Example : MonoBehaviour {
    public SphereCollider sc;
    void Example() {
        gameObject.AddComponent("FoobarScript");
        sc = gameObject.AddComponent("SphereCollider") as SphereCollider;
*/