using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public blockKill[] killed;
    public TMPro.TMP_Text scoreText;
    public float Score;

    private void Start()
    {
        Score = 0;
    }


    void Update()
    {
        Score += 10 * Time.deltaTime;
        scoreText.text = Score.ToString("0");

        if (killed[0].Respawn == true)
        {
            Score = 0;
            killed[0].Respawn = false;
        }

        if (killed[1].Respawn == true)
        {
            Score = 0;
            killed[1].Respawn = false;
        }
    }

    
}
