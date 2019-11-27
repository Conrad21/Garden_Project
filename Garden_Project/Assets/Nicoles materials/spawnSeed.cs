using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnSeed : MonoBehaviour
{
 
    public GameObject seed;
    public Transform seed2;
    public float x=0;
    public float y =0;
    public float z =0;
    public float waitTime = 10.0f;
    private float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    public void spawn()
    {

        


        if (timer > waitTime)
        {
           
            // seed.SetActive(true);
            Instantiate(seed2, new Vector3(x, y, z), Quaternion.identity);
            timer = 0;
        }
    }
 

}
