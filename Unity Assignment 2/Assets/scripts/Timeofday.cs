using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timeofday : MonoBehaviour
{
   
  //  public MeshRenderer Windows;
    // public Slider windowlight;

    [SerializeField]
    GameObject Sunslider;

    void Update()
    {
       
        transform.rotation = Quaternion.Euler(Sunslider.GetComponent<Slider>().value * 360, 0, 0);
    }

   


}
