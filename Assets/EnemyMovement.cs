using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour{
    [SerializeField] List<Waypoint> blocklist;
    
    void Start()
    {
        StartCoroutine(FollowPath());
       
    }
   
    IEnumerator FollowPath()
    {
        print("Start Patroling");
       foreach(Waypoint waypoint in blocklist )
        {
            print(waypoint.name);
            gameObject.transform.position = waypoint.transform.position;
            
            yield return new WaitForSeconds(1f);
           
        }
        print("Patroling Over");
   }   
}
