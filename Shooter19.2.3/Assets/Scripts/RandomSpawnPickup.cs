using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPickup
    : MonoBehaviour
     
{
    //set a location for your pickup
    //setting which prefab you want to spawn
    //setting a time to spawn, this can be changed in inspector
  
	public GameObject pickupPrefab;
	public float spawnTime = 5f;
    public Transform spawnLoc;
	// Start is called before the first frame update
	void Start()
	{
        //calling the pickup repeat method
        StartCoroutine(PickupRepeat());

	}
    private void SpawnPickup()
	{
        //this will instansiate a new prefab, and in the prefab location
        Instantiate(pickupPrefab, spawnLoc.position, spawnLoc.rotation);
	}
    IEnumerator PickupRepeat()
	{
		while (true)
		{
            //calling the spawn pickup and repeating it for the seconds set in the inspector
			yield return new WaitForSeconds(spawnTime);
			SpawnPickup();
		}
	}


	// Update is called once per frame
	void Update()
	{

	}
    
	


}
