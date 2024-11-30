using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject[] platformPrefabs;  // Array of platform prefabs
    [SerializeField] int offset = 10;
    [SerializeField] float minSpawnTime = 0.25f;
    [SerializeField] float maxSpawnTime = 1f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {

    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            float randomTime = Random.Range(minSpawnTime, maxSpawnTime);

            float randomOffsetX = Random.Range(-offset, offset);

            Vector3 spawnPos = spawner.transform.position;
            spawnPos.x += randomOffsetX;

            // Choose a random platform prefab from the array
            int randomIndex = Random.Range(0, platformPrefabs.Length);
            GameObject platformToSpawn = platformPrefabs[randomIndex];

            yield return new WaitForSeconds(randomTime);

            // Instantiate the randomly chosen platform at the spawn position
            Instantiate(platformToSpawn, spawnPos, spawner.transform.rotation);
        }
    }
}
