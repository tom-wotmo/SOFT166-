using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject AttackSpeed, DamageIncrease, Invincible, MoveSpeed, Health;

    public float spawntime = 5f;

    float nextPickup = 0f;

    int whatToSpawn;

    void Update()
    {
        if (Time.time > nextPickup)
        {
            whatToSpawn = Random.Range(1, 6);
            Debug.Log(whatToSpawn);
        }
        switch (whatToSpawn)
        {
            case 1:
                Instantiate(AttackSpeed, transform.position, Quaternion.identity);
                break;

            case 2:
                Instantiate(DamageIncrease, transform.position, Quaternion.identity);
                break;

            case 3: Instantiate(Invincible, transform.position, Quaternion.identity);
                break;

            case 4: Instantiate(MoveSpeed, transform.position, Quaternion.identity);
                break;

            case 5: Instantiate(Health, transform.position, Quaternion.identity);
                break;

        }
        nextPickup = Time.time + spawntime;


            
    }
}
