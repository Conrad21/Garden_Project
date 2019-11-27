using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class testingcol : MonoBehaviour
{
    public GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision ground)
    {
        if (ground.gameObject.tag == "water")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("The tag water touched it");

        }

        if (ground.gameObject.name == "water")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("oject named water touched it");

        }

       

        Debug.Log("something touch it I think");
    }
}
