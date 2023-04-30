using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
   public Timer timer;

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag == "Player")
      {
         timer.StartTimer();
      }
   }
}
