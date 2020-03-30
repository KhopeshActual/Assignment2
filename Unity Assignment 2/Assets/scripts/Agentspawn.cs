using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//attach script to appartment buidings 
public class Agentspawn : MonoBehaviour
{
    public GameObject Agent;
    public GameObject[] Apartments;
  

    // Start is called before the first frame update
    void Start()
    {
        //sets spawn time and duration
        InvokeRepeating("spawn", 2f, 4f);
       // Apartments = GameObject.FindGameObjectsWithTag("building");
    }
   
    public void spawn()
    {
        Invoke("spawn", Random.Range(2, 5));

        Apartments = GameObject.FindGameObjectsWithTag("building");
        GameObject spawnagent = Instantiate(Agent, Apartments[Random.Range(0, Apartments.Length)].transform.position, Quaternion.identity);
        spawnagent.GetComponent<AgentTotarget>().setgoal(Apartments[Random.Range(0, Apartments.Length)].transform.position);
    }

    
}

