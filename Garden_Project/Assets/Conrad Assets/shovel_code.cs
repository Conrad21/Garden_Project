using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shovel_code : MonoBehaviour
{
    public GameObject shovelcomp;

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
        if (bucket.gameObject.tag == "compost" && !shovelcomp.activeInHierarchy)
        {
            shovelcomp.SetActive(true); 
            Destroy(bucket.gameObject);
        }
    }
}
