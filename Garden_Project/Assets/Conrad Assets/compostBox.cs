using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compostBox : MonoBehaviour
{
    public GameObject compost1;
    public GameObject compost2;
    public GameObject compost3;
    public GameObject compostsmall;
    public GameObject compostmed;
    public GameObject compostbig;
  //  public GameObject compostsound;
    private int counter = 1;
    public AudioClip AudioClip;
    public AudioSource AudioSource;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c)
    {
       if (c.gameObject.tag == "bucket" && (compost1.activeInHierarchy || compost2.activeInHierarchy || compost3.activeInHierarchy))
        {
            AudioSource.Play();


            compost1.SetActive(false);
            compost2.SetActive(false);
            compost3.SetActive(false);
            if (counter == 1)
            {
                compostsmall.SetActive(true);
                counter = 2; 
            }

            else if (counter == 2)
            {
                compostsmall.SetActive(false);
                compostmed.SetActive(true);
                counter = 3; 
            }

            else if (counter == 3)
            {
                compostmed.SetActive(false);
                compostbig.SetActive(true);
            }

        }




    }



}
