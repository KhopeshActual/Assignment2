using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCity : MonoBehaviour
{
   
    public void clearDemo()
    {
        GameObject[] destroyonload = GameObject.FindGameObjectsWithTag("destroy on load");
        for (int i = 0; i < destroyonload.Length; i++)
        {
            Destroy(destroyonload[i]);
        }
    }
    // Update is called once per frame
    public void ClearALL()
    {
       
        //destroy all objects tagged "building"
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("building");

        for (int i = 0; i < allObjects.Length; i++)
        {
           Destroy(allObjects[i]);
        }
        //destroy all objects tagged "agent"
        GameObject[] allagents = GameObject.FindGameObjectsWithTag("agent");

        for (int i = 0; i < allagents.Length; i++)
        {
            Destroy(allagents[i]);
        }
    }
}
