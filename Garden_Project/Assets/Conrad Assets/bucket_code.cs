using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket_code : MonoBehaviour
{
    public GameObject bucket;
    public GameObject compost;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision bucket)
    {
        if (bucket.gameObject.tag == "compost")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("You put compost in the bucket");
            GameObject tmp = GameObject.FindWithTag("compost");
            Destroy(tmp);
            compost.SetActive(true);

        }

    }

}
