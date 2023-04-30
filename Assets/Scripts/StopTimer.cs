using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
   public Timer timer;


   private void OnTriggerExit(Collider other)
   {
      if (other.gameObject.tag == "Player")
      {
         timer.StopTimer();
      }
   }
}
