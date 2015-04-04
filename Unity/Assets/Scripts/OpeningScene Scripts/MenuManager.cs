﻿using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void quitButtonClick(){
		Application.Quit();
	}

	public void newGameButtonClick(){
		if(Application.CanStreamedLevelBeLoaded("Village Management")){
			Application.LoadLevel ("Village Management");
		}
	}
}