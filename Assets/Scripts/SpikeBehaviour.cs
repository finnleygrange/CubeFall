using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class SpikeBehaviour : MonoBehaviour
{
    private float elapsedTime;
    private float score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.timeSinceLevelLoad;
        score = (int)(elapsedTime * 100);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            File.WriteAllText("score.txt", score.ToString());
            SceneManager.LoadScene(0);
        }
    }
}
