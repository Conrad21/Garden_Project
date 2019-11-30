using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBug : MonoBehaviour
{

    public GameObject splat;
    public GameObject bug;
    public float waitTime = 20.0f;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > waitTime * 3)
        {

            var Vector3 = splat.transform.position;
            Instantiate(bug, Vector3, Quaternion.identity);
            splat.SetActive(false);

        }
    }
}
