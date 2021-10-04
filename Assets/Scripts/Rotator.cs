using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float minSpeed = 5f;
    public float maxSpeed = 10f;

    private float speed;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        Debug.Log("Spawing rock at " + speed + " speed");
    }

    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(0, 0, speed));
    }
}
