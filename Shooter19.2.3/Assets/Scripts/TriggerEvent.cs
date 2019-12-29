using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    public Transform spawn;
    public GameObject spawnedobject;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Instantiate(spawnedobject, spawn.position, spawn.rotation);
        
    }

   
}
