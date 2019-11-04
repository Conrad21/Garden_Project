using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour
{

    public AudioClip AudioClip;
    public AudioSource AudioSource;

    public void playmusic()
    {

        if (!AudioSource.isPlaying)
        {
            AudioSource.Play();
        }
        else if (AudioSource.isPlaying)
        {
            AudioSource.Stop();
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
