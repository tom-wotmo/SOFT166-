using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
   

   public void Death()
    {
        //sets the game object inactive once dead instead of destroying it so it can activate another gameobject e.g. gameover

        gameObject.SetActive(false);
    }
   
}

