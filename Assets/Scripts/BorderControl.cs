using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderControl : MonoBehaviour
{
    public GameObject spawn1, spawn2, player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if(this.tag == "border1")
            {
                player.transform.position = spawn2.transform.position;
            }
            else if(this.tag == "border2")
            {
                player.transform.position = spawn1.transform.position;
            }
        }
    }

}
