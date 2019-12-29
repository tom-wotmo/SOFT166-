using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public Transform spawnLoc;
    public GameObject spawnObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // this will spawn the object when the player passes through it
        Instantiate(spawnObject, spawnLoc.position, spawnLoc.rotation);

        //this then destroys the game object so that you aren't continously spawning loads of them
        Destroy(gameObject);

    }


}
