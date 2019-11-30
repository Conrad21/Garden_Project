  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutgrass : MonoBehaviour
{

    public int clockMultiplier = 1;
    public GameObject grass;
    public float waitTime = 20.0f;
    private float timer = 0.0f;
    public AudioSource snipSource;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * clockMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer > waitTime)
        {
            //Debug.Log("in the if");
            timer = 0.0f;
            grasscomeback();

        }
    }

    void OnCollisionEnter(Collision cutter)
    {
        //Debug.Log(cutter.gameObject.tag);
        if (cutter.gameObject.tag == "scythe")
        {
            snipSource.Play();
            //Debug.Log("chahahahahaha");
            grass.SetActive(false);
        }
    }


    void grasscomeback()
    {
        grass.SetActive(true);
    }

}
