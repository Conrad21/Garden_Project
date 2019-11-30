using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killMovingBug : MonoBehaviour
{
    public GameObject splat;
    public GameObject bug;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "swatter")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");

            var Vector3 = bug.transform.position;
            Instantiate(splat, Vector3, Quaternion.identity);
            bug.SetActive(false);
        }
    }
}
