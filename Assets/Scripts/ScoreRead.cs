using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class ScoreRead : MonoBehaviour
{
    public TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        string score = File.ReadAllText("score.txt");
        text.text = "Last score: " +score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
