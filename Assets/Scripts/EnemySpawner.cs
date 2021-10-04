using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Sprite[] EnemyTypes;
    public Color[] colours;
    public float maxHorizontalVelocity = 0;

    public float _spawnInterval = 4f;

    //Make it harder as the game goes on but not impossible.
    private float _spawnIntervalMin = 1f;
    private float _lastSpawnTime = 0f;

    private void Start()
    {
        StartCoroutine(SpeedUp());
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

            Enemy.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(0, maxHorizontalVelocity), 0));

        }
    }

    public IEnumerator SpeedUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(10f);
            _spawnInterval -= 0.4f;
            Debug.Log("_spawnInterval changed! " + _spawnInterval);
        }
    }
}
