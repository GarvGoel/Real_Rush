using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
[ExecuteInEditMode]    //allows changes to occur in editing mode(scene view)
public class SnapWork : MonoBehaviour {
  
    
     Vector3 SnapPos;
    TextMesh textMesh;
    Waypoint waypoint;

    void Awake()
    {
        waypoint = GetComponent<Waypoint>();
        textMesh = GetComponentInChildren<TextMesh>();  //component of a children is taken in a variable
   }



    void Update()
    {
        SnapToGrid();
        UpdateLabel();

    }

    private void SnapToGrid()
    {
        int gridSize = waypoint.GetGridSize();
        SnapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        SnapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = new Vector3(SnapPos.x, 0, SnapPos.z);
    }

    private void UpdateLabel()
    {
        string cordinates = SnapPos.x + "," + SnapPos.z;
        textMesh.text = cordinates;
        gameObject.name = "Cube(" + cordinates + ")";
    }


}
