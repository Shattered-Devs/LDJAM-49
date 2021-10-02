using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAura : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.GetComponent<PlayerHealthManager>().TakeDamage();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerHealthManager>().TakeDamage();
        }
    }

}
