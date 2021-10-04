using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventItemDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameObject.Destroy(collision.gameObject);
        }
    }
}
