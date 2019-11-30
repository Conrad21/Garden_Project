using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBug : MonoBehaviour
{
    public GameObject splat;
    public GameObject bug;
    public float waitTime = 20.0f;
    private float timer = 0.0f;

    private int flag = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       // Debug.Log("in timer");
        //Debug.Log(timer);

        if ((timer > waitTime) && (flag == 1))
        {

            splat.SetActive(false);
            flag = 0;

        }
    }

    void OnCollisionEnter(Collision collision)
    {


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "swatter")
        {
            //If the GameObject has the same tag as specified, output this message in the console
           Debug.Log("Do something else here");
            bug.SetActive(false);
            splat.SetActive(true);
            timer = 0.0f;
            flag = 1;
        }

    }
}
