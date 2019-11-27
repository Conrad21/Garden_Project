using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingplant : MonoBehaviour
{
  

    public int m = 1;
    public GameObject cabbage;
    public GameObject littlecab;
    public GameObject seedling;

    //public GameObject lettuse;
    //public GameObject flower1;
    /// public GameObject pumpkin;
    public GameObject ground;
    public float waitTime = 3.0f;
    public float waitTime2 = 10.0f;
    public float waitTime3 = 15.0f;
    public float waitwater = 120.0f;
    private float timer = 0.0f;
    private float timer2 = 0.0f;
    public float x = 1;
    public float y = 1;
    public float z = 1;
    private bool plantIsHere = false;
    private bool isWatered = false;
    private bool plantIsAlive = false;

    private bool phase1 = false;
    private bool phase2 = false;
    private bool phase3 = false;
    private bool phase4 = false;
    private bool waterflag = false;
    private int flag = 0;
  


    GameObject general;
    GameObject general2;
    GameObject general3;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * m;
        waitTime2 = waitTime2 * m;
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
            //plantGrow();
            var cubeRenderer = general3.GetComponent<Renderer>();
            cubeRenderer.material.color = new Color(1, 1, 1);

        }

        if (timer2 > waitwater && waterflag == false)
        {
            Debug.Log("you did not water the plant :( ");
            waterflag = true; 




        }


        if (isWatered == false && plantIsAlive == false)
        {
          //  var cubeRenderer = general2.GetComponent<Renderer>();

            //Call SetColor using the shader property name "_Color" and setting the color to red
           // cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }

    void OnCollisionEnter(Collision ground)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (ground.gameObject.name == "dirt")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //  Debug.Log("Do something here");

        }


        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (ground.gameObject.tag == "seed" && plantIsHere == false)
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Seed as been planted");
            general = seedling;
            general2 = littlecab;
            general3 = cabbage;

            //Destroy(GameObject.FindWithTag("box"));
            GameObject tmp = GameObject.FindWithTag("seed");
            Destroy(tmp);

            plantIsHere = true;
            plantIsAlive = true;

            timer = 0.0f;
            timer2 = 0.0f;
            flag = 1;
        }



        if (ground.gameObject.tag == "water")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Plant is watered");
            timer2 = 0.0f;


        }


        if (ground.gameObject.tag == "shovel")
        {
            general.SetActive(false);
            general2.SetActive(false);
            general3.SetActive(false);
            Debug.Log("Plant is gone");
        }

       // Debug.Log("someting growing did touch it");
    }

}


