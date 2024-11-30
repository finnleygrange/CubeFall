using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject spawnerPrefab;
    [SerializeField] int offset = 10;
    [SerializeField] float minSpawnTime = 0.25f;
    [SerializeField] float maxSpawnTime = 1f;

    void Start()
    {
        StartCoroutine(Spawn(spawnerPrefab));
    }

    void Update()
    {

    }

    public IEnumerator Spawn(GameObject platform)
    {
        while (true)
        {
            float randomTime = Random.Range(minSpawnTime, maxSpawnTime);

            float randomOffsetX = Random.Range(-offset, offset);

            Vector3 spawnPos = spawner.transform.position;
            spawnPos.x += randomOffsetX;

            yield return new WaitForSeconds(randomTime);

            Instantiate(platform, spawnPos, spawner.transform.rotation);
        }
    }
}
