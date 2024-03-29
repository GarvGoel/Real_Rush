﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour {
    Dictionary<Vector2Int, Waypoint> grid = new Dictionary<Vector2Int, Waypoint>();  //grid is name of dictionary


	// Use this for initialization
	void Start ()
    {
        LoadBlocks();

    }

    private void LoadBlocks()
    {
        var waypoints = FindObjectsOfType<Waypoint>(); // it is a list of all gameobjects having waypoint(component)
        foreach(Waypoint waypoint in waypoints)
        {
            grid.Add(waypoint.GetGridPos(), waypoint);
        }
        print(grid.Count);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
