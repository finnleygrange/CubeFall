using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject spawnerPrefab;
    [SerializeField] int offset = 10;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn(2, spawnerPrefab));

    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Spawn(float time, GameObject platform)
    {
        while (true)
        {
            float randomOffsetX = Random.Range(-offset, offset);

            Vector3 spawnPos = spawner.transform.position;
            spawnPos.x = randomOffsetX;


            yield return new WaitForSeconds(time);
            Instantiate(platform, spawnPos, spawner.transform.rotation);
        }
    }
}
