﻿using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 100.0f;
    public int damage = 1;
    // Start is called before the first frame update
    private void Start()
    {
        print("!!!");
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed);
        
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
    }

    private void OnBecameInvisible()
    {
        Die();
        
    }
    private void Die()
    {
        Destroy(gameObject);
    }

 
}
