using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class Scrolling : MonoBehaviour
{
    public GameObject prefab;
    public Camera cameraPrefab;

    public UnityEvent SCROLLED;
    
    public float speed;

    private Vector2 _totalSize;
    
    private void FixedUpdate()
    {
        transform.Translate(0, speed * Time.fixedDeltaTime, 0);
        if (transform.position.y < -(cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)))
        {
            // Top to Bottom
            transform.position = new Vector3(transform.position.x, (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)), 0);
            SCROLLED.Invoke();
        }
        else if (transform.position.y > (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)))
        {
            // Bottom to Top
            transform.position = new Vector3(transform.position.x, transform.position.y - (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)) - (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)), 0);
            SCROLLED.Invoke();
        }

    }
}