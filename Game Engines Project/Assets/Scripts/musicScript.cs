using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicScript : MonoBehaviour
{
    public TMPro.TMP_Dropdown songDropdown;
    public int songIndex;
    public GameObject This;
    public AudioSource Music;
    public AudioClip[] Songs;

    private void Awake()
    {
        DontDestroyOnLoad(This); 
    }

    private void Start()
    {
        Music = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
            Music.Stop();
             }
    }


    public void PlayMusic()
    {
        songIndex = songDropdown.value;
        Music.clip = Songs [songIndex];
         Music.Play();

    }
}
