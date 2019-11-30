using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLimit : MonoBehaviour
{
    public GameObject seed;

    public float waitTime = 30.0f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > waitTime )
        {

            Destroy(seed.gameObject);

        }

    }
}
