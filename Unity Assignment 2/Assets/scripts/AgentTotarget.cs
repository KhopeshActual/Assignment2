using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentTotarget : MonoBehaviour
{

    public static GameObject[] BuildingArray;
    int Buildingindex;
    public NavMeshAgent agent;
    public Vector3 goal;

    // Start is called before the first frame update
    void Start()
    {
        BuildingArray = GameObject.FindGameObjectsWithTag("building");
        agent = GetComponent<NavMeshAgent>();
    }

    public void setgoal(Vector3 goal)
    {
        this.goal = goal;
    }

    void Update()
    {
        agent.destination = goal;

       /* if (agent.remainingDistance <= 0.2f)
         {
             Destroy(gameObject);
         }  */
    }
    
}
   
    

