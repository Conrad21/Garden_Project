using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pullweed : MonoBehaviour
{
    public int clockMultiplier = 1;
    public GameObject weed;
    private float waitTime = 30.0f;
    private float timer = 0.0f;
    private bool flag = false;
    public AudioSource snipSource;
    public ParticleSystem grasscuttingeffect;
    // public AudioClip snip;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * clockMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer > waitTime && flag == false)
        {
            //Debug.Log("in the if");
     
           weedcomeback();

        }

    }

    void OnCollisionEnter(Collision cutter)
    {


        if ((cutter.gameObject.tag == "sheer") &&(weed.activeInHierarchy))
        {

            grasscuttingeffect.Play();
            snipSource.Play();
            weed.SetActive(false);
            timer = 0.0f;

           // weed.SetActive(false);
            flag = false; 
        }
    }


    void weedcomeback()
    {
        weed.SetActive(true);
        flag = true; 
    }
}
