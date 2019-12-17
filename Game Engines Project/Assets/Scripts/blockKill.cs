using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockKill : MonoBehaviour
{
    public GameObject Spawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Kill")
        {
            if(col.gameObject.tag == "Player")
            {
                col.gameObject.transform.position = Spawn.transform.position;
            }
            else
            {
                Destroy(col.gameObject);
            }
           
        }
    }

}
