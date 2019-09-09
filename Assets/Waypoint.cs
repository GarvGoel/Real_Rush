﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

    const int gridSize = 10;
 

    // Use this for initialization
    void Start()
    {
       
    }
        public int  GetGridSize()
        {
            return gridSize;
        }


   public Vector2Int GetGridPos()
    {
         return new Vector2Int(
         Mathf.RoundToInt(transform.position.x / gridSize) * gridSize,
         Mathf.RoundToInt(transform.position.z / gridSize) * gridSize);
    }


    // Update is called once per frame
    void Update () {
		
	}
}
