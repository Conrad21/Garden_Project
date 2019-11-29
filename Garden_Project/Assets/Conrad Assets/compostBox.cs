using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compostBox : MonoBehaviour
{
    public int clockMultiplier = 1;
    public GameObject compost1;
    public GameObject compost2;
    public GameObject compost3;
    public GameObject Readycompost1;
    public GameObject Readycompost2;
    public GameObject Readycompost3;
    public GameObject compostsmall;
    public GameObject compostmed;
    public GameObject compostbig;
    public GameObject shovelcompost;
    public GameObject readyShovelcompost;
    private int flag = 0; 
    //  public GameObject compostsound;
    public int counter = 0;
    public AudioClip AudioClip;
    public AudioSource AudioSource;

    private float timer = 0.0f;
    public float waitTime = 10.0f;

    private int Compostcounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * clockMultiplier;



    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (flag == 1)
        {
            updateCompost();
        }
    }

    void OnCollisionEnter(Collision c)
    {
       if (c.gameObject.tag == "bucket" && (compost1.activeInHierarchy || compost2.activeInHierarchy || compost3.activeInHierarchy))
        {
            AudioSource.Play();
            flag = 1; 
            counter = counter + 1;
            timer = 0.0f;
            compost1.SetActive(false);
            compost2.SetActive(false);
            compost3.SetActive(false);

          

        }

        if (c.gameObject.tag == "shovel" && !readyShovelcompost.activeInHierarchy && Compostcounter > 0)
        {
            flag = 1;
            Compostcounter--;
            readyShovelcompost.SetActive(true);
        }
    }

    void updateCompost()
    {
   


        if(Compostcounter < 1)
        {
       
            Readycompost1.SetActive(false);
        }

        if (Compostcounter >= 1)
        {
            flag = 0;
            Readycompost1.SetActive(true);
        }

        else if (Compostcounter > 4 && Compostcounter < 6)
        {
            flag = 0;
            Readycompost1.SetActive(false);
            Readycompost2.SetActive(true);
        }
        else if (Compostcounter >= 6 )
        {
            flag = 0;
            Readycompost1.SetActive(false);
            Readycompost2.SetActive(false);
            Readycompost3.SetActive(true);
        }

        if (counter >= 1 && counter < 3 && (timer > waitTime))
        {
            flag = 0;
            Debug.Log("hhehehe");
            counter = counter - 1;
            Compostcounter++; 
            Readycompost1.SetActive(true);
     
            timer = 0.0f;
        }

        if (counter >= 3 && counter < 6 && (timer > waitTime))
        {
           
            counter = counter - 1;
            Compostcounter++;
            Readycompost1.SetActive(false);
            Readycompost2.SetActive(true);
 
            timer = 0.0f;

        }

        if (counter >= 6 && (timer > waitTime))
        {
            flag = 0;
            Compostcounter++;
            counter = counter - 1;
            Readycompost1.SetActive(false);
            Readycompost2.SetActive(false);
            Readycompost1.SetActive(true);
            timer = 0.0f;


        }



        if (counter == 0)
        {
            Debug.Log("counter++");
            compostsmall.SetActive(false);

        }


        if (counter > 0)
        {

            //Debug.Log("hehehe");
            compostsmall.SetActive(true);

        }

        else if (counter >= 3)
        {
            compostsmall.SetActive(false);
            compostmed.SetActive(true);

        }

        else if (counter >= 6)
        {
            compostmed.SetActive(false);
            compostbig.SetActive(true);

        }


    }

}
