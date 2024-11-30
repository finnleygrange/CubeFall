using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    [SerializeField] GameObject spawner;
    [SerializeField] GameObject spawnerPrefab;

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
            yield return new WaitForSeconds(time);
            Instantiate(platform, spawner.transform.position, spawner.transform.rotation);
        }
    }
}
