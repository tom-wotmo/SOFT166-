using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour
{

    
       
    
    // Start is called before the first frame update
    void Start()
    {
        Button b = GetComponent<Button>();
        AudioSource a = GetComponent<AudioSource>();
        b.onClick.AddListener(delegate () { a.Play(); });

        
    }
  

   
}
