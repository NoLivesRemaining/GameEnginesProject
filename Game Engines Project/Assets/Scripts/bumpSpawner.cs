using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumpSpawner : MonoBehaviour
{
    public GameObject pillar;
    public GameObject platform;
    public float coolDown = 1.0f;
    public float delay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, pillar.transform.localScale.y+3, transform.position.z);

        if (delay == 0)
        {
            platformSpawner();
            delay = coolDown;
        }
        else if (delay >= 0)
        {
            delay -= Time.deltaTime;
        }

        if (delay < 0)
        {
            delay = 0;
        }
    }

    void platformSpawner()
    {
        Instantiate(platform, transform.position, Quaternion.identity);
    }
}
