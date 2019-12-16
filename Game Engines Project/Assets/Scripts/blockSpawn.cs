using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawn : MonoBehaviour
{

    public GameObject Cube;
    
    public float width = 5f;
    public int height = 1;
    public float coolDown = 1.5f;
    public float delay;

    private void Update()
    {
       if (delay == 0)
        {
            BlockSpawner();
            delay = coolDown;
        }
       else if (delay >= 0)
        {
            delay -= Time.deltaTime;
        }

       if ( delay < 0)
        {
            delay = 0;
        }

    }
    void BlockSpawner()
        {
            float halfWidth = width / 2;

            for (int j = 0; j < height; j++)
            {
                for (float i = -halfWidth; i < halfWidth; i++)
                {
                    Vector3 pos = transform.TransformPoint(new Vector3(1.25f * (i + 0.5f), j, 0));

                    GameObject cube = GameObject.Instantiate<GameObject>(Cube, pos, transform.rotation);

                    cube.transform.position = pos;
                    cube.transform.rotation = transform.rotation;

                }
            }
        }
    
    
}
