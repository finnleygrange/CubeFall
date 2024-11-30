using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathArea : MonoBehaviour
{
    private float elapsedTime;
    private  float score;
    public TextMeshPro text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.timeSinceLevelLoad;
        score = (int)(elapsedTime * 100);
        text.text = "Score: "+(score.ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);

            File.WriteAllText("score.txt", score.ToString());

            SceneManager.LoadScene(0);
        }
    }
}
