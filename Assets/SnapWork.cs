using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[DisallowMultipleComponent]
[ExecuteInEditMode]    //allows changes to occur in editing mode(scene view)
public class SnapWork : MonoBehaviour {
  
    
     
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

     void SnapToGrid()
    {

       

        transform.position = new Vector3(waypoint.GetGridPos().x, 0,waypoint.GetGridPos().y);
    }

    

    private void UpdateLabel()
    {
        string cordinates = waypoint.GetGridPos().x + "," + waypoint.GetGridPos().y;
        textMesh.text = cordinates;
        gameObject.name = "Cube(" + cordinates + ")";
    }


}
