using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourLerper : MonoBehaviour
{
    private float speed = 5;
    public Color startColor;
    public Color endColor;
    float startTime;

  

    void Start()
    {
        startTime = Time.time;
    }
    
    void Update()
    {
     
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, endColor, t);
        
    }
}
