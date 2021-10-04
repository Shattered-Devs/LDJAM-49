using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Sprite[] EnemyTypes;
    public Color[] colours;

    private float _spawnInterval = 4f;

    //Make it harder as the game goes on but not impossible.
    private float _spawnIntervalMin = 1f;
    private float _lastSpawnTime = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(Time.time > _lastSpawnTime + _spawnInterval)
        {
            _lastSpawnTime = Time.time;
            Vector3 spawnPos = transform.position;
            spawnPos.x = Random.Range(-4f, 4f);
            GameObject Enemy = Instantiate(EnemyPrefab, spawnPos, Quaternion.identity);

            Enemy.GetComponent<SpriteRenderer>().sprite = EnemyTypes[Random.Range(0, EnemyTypes.Length)];
        }
    }
}
