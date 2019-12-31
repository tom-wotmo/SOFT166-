using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPickup
    : MonoBehaviour
     
{
	public GameObject pickupPrefab;
	public float spawnTime = 5f;
    public Transform spawnLoc;
	// Start is called before the first frame update
	void Start()
	{
        StartCoroutine(PickupRepeat());

	}
    private void SpawnPickup()
	{
        Instantiate(pickupPrefab, spawnLoc.position, spawnLoc.rotation);
	}
    IEnumerator PickupRepeat()
	{
		while (true)
		{
			yield return new WaitForSeconds(spawnTime);
			SpawnPickup();
		}
	}


	// Update is called once per frame
	void Update()
	{

	}
    
	


}
