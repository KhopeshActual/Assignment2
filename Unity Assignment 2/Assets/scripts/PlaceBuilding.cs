using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlaceBuilding : MonoBehaviour
{
    public Camera Maincamera;
    public GameObject prefab;
    public Vector3 offset;

    public GameObject[] BuildingArray;
    public int CurrentBuildingindex;
    
    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject() == false)
        {

            RaycastHit hit;
            Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit, Mathf.Infinity);

            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider != null)
                {
                    Vector3 position = new Vector3(Mathf.Round(hit.point.x), Mathf.Round(hit.point.y), Mathf.Round(hit.point.z));
                    GameObject construct = BuildingArray[CurrentBuildingindex];
                    Instantiate(construct, position + offset, Quaternion.identity);
                }
            }

        }
    }

    public void SetBuildingIndex(int building_number)
    {
       CurrentBuildingindex = building_number;
    }
}

