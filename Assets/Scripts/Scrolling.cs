using System;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Scrolling : MonoBehaviour
{
    public GameObject prefab;
    public Camera cameraPrefab;
    
    public float speed;

    private Vector2 _totalSize;
    
    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

        if (transform.position.y < -(cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)))
        {
            // Top to Bottom
            Instantiate(prefab, new Vector3(transform.position.x, (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)), 0),
                Quaternion.identity);

            Destroy(gameObject);
        }
        else if (transform.position.y > (cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)))
        {
            // Bottom to Top
            Instantiate(prefab, new Vector3(transform.position.x, -(cameraPrefab.rect.yMax * (cameraPrefab.orthographicSize * 2)), 0),
                Quaternion.identity);

            Destroy(gameObject);
        }
    }
}