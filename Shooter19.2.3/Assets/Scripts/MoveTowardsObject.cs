﻿using UnityEngine;


public class MoveTowardsObject: MonoBehaviour
{
    public Transform target;
    public float speed = 5.0f;

    

    private void Update()
    {

        if (PauseUI.GameIsPaused)
        {
            transform.position = transform.position;
        }

        else
        { 
            if (target != null)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
            
            
            }
         }
            
        
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }


}