using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSettings : MonoBehaviour
{
    public GameObject settings;
    private bool show=false;
   public void HideShowSettings()
   {
       if(show)
       {
           show = false;
       }
       else{
           show = true;
       }
       settings.SetActive(show);
   }
}
