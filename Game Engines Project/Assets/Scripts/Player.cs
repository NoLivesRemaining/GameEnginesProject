using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed = 10.0f;
    private Rigidbody rb;
    public bool midJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate(straffe, 0, translation);
        if (midJump == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
                midJump = true;
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        midJump = false;
    }
}



