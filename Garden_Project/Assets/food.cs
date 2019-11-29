using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public GameObject foodmed;
    public GameObject foodLarge;
    public GameObject foodsmall;
    public GameObject bird;
    //public GameObject carrot;
    //public GameObject lettuse;
    //public GameObject flower1;
    /// public GameObject pumpkin;
    public GameObject birdhouse;
    public float waitTime = 20.0f;
    private float timer = 0.0f;
    private int flag = 10;
    GameObject general;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() { 


        timer += Time.deltaTime;
        Debug.Log("in timer");
        Debug.Log(timer);

        if( (timer > waitTime/2) && (flag == 0))
        {
            
            bird.SetActive(true);
            flag = 1;

        }

        if ((timer > waitTime)&& (flag == 1))
        {

            foodLarge.SetActive(false);
            foodmed.SetActive(true);
            flag = 2;
        }
        if ((timer > waitTime*2)&& (flag == 2))
        {
            foodmed.SetActive(false);
            foodsmall.SetActive(true);
            flag = 3;
        }
        if ((timer > waitTime*3)&& (flag == 3))
        {
            foodsmall.SetActive(false);
            bird.SetActive(false);
            flag = 10;
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
    

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "seed")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            
            foodLarge.SetActive(true);
            timer = 0.0f;
            flag = 0;
        }
        
    }
}
