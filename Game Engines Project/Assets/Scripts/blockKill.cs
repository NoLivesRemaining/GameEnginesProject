using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockKill : MonoBehaviour
{
    public GameObject Spawn;
    public bool Respawn = false;

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag != "Kill")
        {
            if(col.gameObject.tag == "Player")
            {
                Respawn = true;
                col.gameObject.transform.position = Spawn.transform.position;
            }
            else
            {
                Destroy(col.gameObject);
            }
           
        }
    }

}
