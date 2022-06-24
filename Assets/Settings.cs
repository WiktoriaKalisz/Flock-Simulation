using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public void SetSlider1(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager1");
      object1.GetComponent<Manager>().maxSpeed = v;
   }
    public void SetSlider2(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager1");
      object1.GetComponent<Manager>().minSpeed = v;
   }
    public void SetSlider3(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager1");
      object1.GetComponent<Manager>().distanceFromNeighbour = v;
   }
    public void SetSlider4(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager1");
      object1.GetComponent<Manager>().avoidanceDistance =v;
   }
    public void SetSlider5(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager1");
      object1.GetComponent<Manager>().speedOfRotation = v;
   }


   public void SetSlider21(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager2");
      object1.GetComponent<Manager>().maxSpeed = v;
   }
    public void SetSlider22(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager2");
      object1.GetComponent<Manager>().minSpeed = v;
   }
    public void SetSlider23(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager2");
      object1.GetComponent<Manager>().distanceFromNeighbour = v;
   }
    public void SetSlider24(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager2");
      object1.GetComponent<Manager>().avoidanceDistance = v;
   }
    public void SetSlider25(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager2");
      object1.GetComponent<Manager>().speedOfRotation = v;
   }


    public void SetSlider31(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager3");
      object1.GetComponent<Manager>().maxSpeed = v;
   }
    public void SetSlider32(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager3");
      object1.GetComponent<Manager>().minSpeed = v;
   }
    public void SetSlider33(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager3");
      object1.GetComponent<Manager>().distanceFromNeighbour = v;
   }
    public void SetSlider34(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager3");
      object1.GetComponent<Manager>().avoidanceDistance = v;
   }
    public void SetSlider35(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager3");
      object1.GetComponent<Manager>().speedOfRotation = v;
   }


    public void SetSlider41(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager4");
      object1.GetComponent<Manager>().maxSpeed = v;
   }
    public void SetSlider42(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager4");
      object1.GetComponent<Manager>().minSpeed = v;
   }
    public void SetSlider43(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager4");
      object1.GetComponent<Manager>().distanceFromNeighbour = v;
   }
    public void SetSlider44(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager4");
      object1.GetComponent<Manager>().avoidanceDistance = v;
   }
    public void SetSlider45(float v)
   {
      GameObject object1 = GameObject.FindGameObjectWithTag("Manager4");
      object1.GetComponent<Manager>().speedOfRotation = v;
   }
}
