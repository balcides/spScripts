using UnityEngine;
using System.Collections;

public class Screensize : MonoBehaviour {
	
	public enum screenSize {web, droid, iphone, ipad, tablet, pc, osx, fullScreen};
	public screenSize resolution;
	
    screenSize ScreenSize (screenSize resolution)
    {
        if(resolution == screenSize.web){ 			print("web rez enabled"); }
        else if(resolution == screenSize.droid){ 	print("droid rez  enabled"); }
        else if(resolution == screenSize.iphone){ 		print("iphone rez enabled");  }
        else if(resolution == screenSize.ipad){ print("ipad rez enabled");  }
        else if(resolution == screenSize.tablet){ 	print("tablet rez enabled");  }
		else if(resolution == screenSize.pc){ print("pc rez enabled");  }
		else if(resolution == screenSize.osx){ print("OSX rez enabled");  }
		else if(resolution == screenSize.fullScreen){ print("fullScreen rez enabled");  }
		else{}
		
        return resolution;     
    }
	

	// Use this for initialization
	void Start () {
		
		//initialize controls
		ScreenSize(resolution);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
