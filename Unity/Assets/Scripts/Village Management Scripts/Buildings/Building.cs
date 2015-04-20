﻿using UnityEngine;
using System.Collections;

public abstract class Building {
	
	public int buildingType {
		get;
		set;
	}

	public string Name { get; set; }
	public int Level { get; set; }

	public Building(int buildingType){
		this.buildingType = buildingType;
		this.Level = 1;
	}
	
	public abstract void applyBuildingEffects(ResourceManager resourceManager);

}
