using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    [SerializeField] float moveSpeed = 3f, maxMoveSpeed  = 20f;
    float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 20f);
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime = Time.timeSinceLevelLoad;
        if (moveSpeed<= maxMoveSpeed )
        {
            moveSpeed += (elapsedTime / 100000);
        }
        
        
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

    }
    
}
