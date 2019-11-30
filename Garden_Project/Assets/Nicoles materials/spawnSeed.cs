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
    public float waitTime = 15.0f;
    private float timer = 0.0f;
    private int limit = 5;
    private int counter = 0;
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

        if( (timer > waitTime) )
        {
           
            // seed.SetActive(true);
            Instantiate(seed2, new Vector3(x, y, z), Quaternion.identity);
            //counter = counter + 1;
            timer = 0;
        }
    }
 

}
