using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingplant : MonoBehaviour
{
  

    public int clockMultiplier = 1;
    private float compostSpeedUp = 0.75f;
    private float weedslowdown = 1.25f;
    public GameObject weed1;
    public GameObject weed2;
    public GameObject compflag; 
    public GameObject cabbage;
    public GameObject littlecab;
    public GameObject seedling;
    public GameObject hole;
    public GameObject deadplant;
    public GameObject tallblueflower;
    public GameObject smalltallblueflower;
    public GameObject mushroom;
    public GameObject smallmushroom;
    public GameObject caladium;
    public GameObject smallCaladium;
    public GameObject sunflower;
    public GameObject smallSunflower;
    public GameObject purpleFlower;
    public GameObject smallpurpleflowers;
    public GameObject pumpkin;
    public GameObject smallPumpkin;
    public GameObject Bocchoy;
    public GameObject smallBocchoy;
    public GameObject readyCompost;
    public GameObject smallCarrot;
    public GameObject Carrot;

    public GameObject spawnpoint;
    public GameObject createdcompost;
    //public Transform compostTrans;
    public GameObject compostonshovel;

    private float waitTime = 10.0f;
    private float waitTime2 = 20.0f;
    private float waitTime3 = 40.0f;
    private float waitTime_1 = 10.0f;
    private float waitTime2_1 = 20.0f;
    private float waitTime3_1 = 40.0f;
    private float compwaitTime = 0f;
    private float compwaitTime2 = 0f;
    private float compwaitTime3 = 0f;
    private float weedwait = 0f;
    private float weedwait2 = 0f;
    private float weedwait3 = 0f;
    private float waitwater = 35.0f;

    private float timer = 0.0f;
    private float timer2 = 0.0f;

    private bool plantIsHere = false;
    private bool isWatered = false;
    private bool plantIsAlive = false;
    private bool holeIsHere = false;
    private bool waterflag = false;

    private bool phase1 = false;
    private bool phase2 = false;
    private bool phase3 = false;
    private bool phase4 = false;

    private int flag = 0;

    GameObject general;
    GameObject general2;
    GameObject general3;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * clockMultiplier;
        waitTime2 = waitTime2 * clockMultiplier;
        waitTime3 = waitTime3 * clockMultiplier;
        compwaitTime = waitTime * compostSpeedUp;
        compwaitTime2 = waitTime2 * compostSpeedUp;
        compwaitTime3 = (waitTime3 * compostSpeedUp);
        weedwait = waitTime * weedslowdown;
        weedwait2 = waitTime2 * weedslowdown;
        weedwait3 = waitTime3 * weedslowdown;
        waitwater = waitwater * clockMultiplier;
        Debug.Log(compwaitTime3);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        timer2 += Time.deltaTime;


        if (flag == 1){
            PlantThing(); }





    }

    void PlantThing() {
        if (timer > waitTime && phase1 == false && phase3 == false)
        {
            //Debug.Log("in the plant");
            //plantGrow();
            general.SetActive(true);
            phase1 = true;
        }


        if (timer > waitTime2 && phase1 == true && phase3 == false)
        {

            Debug.Log("wait time 2");
            general.SetActive(false);
            general2.SetActive(true);
            //plantGrow();

        }


        if (timer > waitTime3 && phase3 == false)
        {
            Debug.Log("wait time 3");
            general2.SetActive(false);
            general3.SetActive(true);
            phase3 = true;
            phase4 = true;
          
        }

        if (timer2 > waitwater && waterflag == false)
        {
            Debug.Log("you did not water the plant :( ");
            waterflag = true;
            general2.SetActive(false);
            general.SetActive(false);
            general3.SetActive(false);
            deadplant.SetActive(true);
            compflag.SetActive(false);
            flag = 0;


        }

        if((weed1.activeInHierarchy) || (weed2.activeInHierarchy))
        {
            waitTime = weedwait; 
            waitTime2 = weedwait2;
            waitTime3 = weedwait3;
        }



    }

    void OnCollisionEnter(Collision ground)
    {
        Debug.Log(ground.gameObject.tag);

        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (ground.gameObject.name == "dirt")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //  Debug.Log("Do something here");

        }

//------------------------------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------------------------------

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (ground.gameObject.tag == "seed_cabbage" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = littlecab;
            general3 = cabbage;

            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;
            holeIsHere = false; 
            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }


       else if (ground.gameObject.tag == "seed_blueFlower" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Blue Seed as been planted");
            general = seedling;
            general2 = smalltallblueflower;
            general3 = tallblueflower;

            Destroy(ground.gameObject);
            hole.SetActive(false);

            plantIsHere = true;
            plantIsAlive = true;
            holeIsHere = false;
            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

       else if (ground.gameObject.tag == "seed_Carrot" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallCarrot;
            general3 = Carrot;

            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;
            holeIsHere = false;
            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }


       else if (ground.gameObject.tag == "seed_pumpkin" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallPumpkin ;
            general3 = pumpkin;

            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;
            holeIsHere = false;
            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

       else if (ground.gameObject.tag == "seed_sunflower" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallSunflower;
            general3 = sunflower;
            holeIsHere = false;
            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

       else if (ground.gameObject.tag == "seed_purpleFlower" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallpurpleflowers;
            general3 = purpleFlower;
            holeIsHere = false;
            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

        else if (ground.gameObject.tag == "seed_caladium" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallCaladium;
            general3 = caladium;
            holeIsHere = false;
            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

        else if (ground.gameObject.tag == "seed_whiteMushroom" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallmushroom;
            general3 = mushroom;
            holeIsHere = false;
            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }

       else if (ground.gameObject.tag == "seed_bokchoy" && plantIsHere == false && holeIsHere == true)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = smallBocchoy;
            general3 = Bocchoy;
            holeIsHere = false;
            Destroy(ground.gameObject);
            hole.SetActive(false);
            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }


       // Debug.Log("Something touch the ground");





        //====================================================================================================

        if (ground.gameObject.tag == "water")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Plant is watered");
            timer2 = 0.0f;


        }


        if (ground.gameObject.tag == "shovel")
        {
           if(plantIsHere == false && holeIsHere == false && !compostonshovel.activeInHierarchy)
            {
                holeIsHere = true; 
                hole.SetActive(true);
            }

            if (readyCompost.activeInHierarchy)
            {
                waitTime = compwaitTime;
                waitTime2 = compwaitTime2;
                waitTime3 = compwaitTime3;
                Debug.Log(waitTime3);
                compflag.SetActive(true);
                readyCompost.SetActive(false);
            }

        }

        if (ground.gameObject.tag == "sheer")
        {
            Debug.Log("sheers");
            if (plantIsHere == true)
            {
                general2.SetActive(false);
                general.SetActive(false);
                general3.SetActive(false);
                deadplant.SetActive(false);
                compflag.SetActive(false);
                plantIsHere = false;
                waitTime = waitTime_1;
                waitTime2 = waitTime2_1;
                waitTime3 = waitTime3_1;
                flag = 0; 
                var Vector3 = spawnpoint.transform.position;
                Instantiate(createdcompost, Vector3, Quaternion.identity);
            }
        }



       // Debug.Log("someting growing did touch it");
    }

}


