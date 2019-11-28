using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket_code : MonoBehaviour
{
  //  public GameObject bucket;
    public GameObject shovelcomp;
    public GameObject compost1;
    public GameObject compost2;
    public GameObject compost3;

    public int counter = 0; 
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
        if (bucket.gameObject.tag == "shovel" && shovelcomp.activeInHierarchy)
        {
            if (counter == 0)
            {
                //If the GameObject's name matches the one you suggest, output this message in the console
                Debug.Log("You put compost in the bucket 1");
          
                compost1.SetActive(true);
                shovelcomp.SetActive(false); 
                counter = 1; 
            }

           else if (counter == 1)
            {
                Debug.Log("You put compost in the bucket 2");
               
                compost1.SetActive(false);
                compost2.SetActive(true);
                shovelcomp.SetActive(false);
                counter = 3;
            }
            else if (counter == 3)
            {
                Debug.Log("You put compost in the bucket 3");
                compost1.SetActive(false);
                compost2.SetActive(false);
                compost3.SetActive(true);
                shovelcomp.SetActive(false);
            }
        }

    }

}
