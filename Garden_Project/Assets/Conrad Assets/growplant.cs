using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growplant : MonoBehaviour
{
    public GameObject cabbage;
    public GameObject babyCab;
    //public GameObject lettuse;
    //public GameObject flower1;
    /// public GameObject pumpkin;
    public GameObject ground;
    public float waitTime = 3.0f;
    public float waitTime2 = 10.0f;
    private float timer = 0.0f;
    private float timer2 = 0.0f;
    public float x = 1;
    public float y = 1;
    public float z = 1;
    private bool plantIsHere = false; 
    GameObject general;
    GameObject general2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;

        if (timer > waitTime)
        {
            Debug.Log("in the plant");
            //plantGrow();
            general.SetActive(true);
        }

        if (timer > waitTime2)
        {
            Debug.Log("in the if");
            general.SetActive(false);
            general2.SetActive(true);
            //plantGrow();

        }

        if (timer2 > waitTime2*2)
        {
            Debug.Log("in the if");
            plantGrow(general2);

        }

    }
    public void plantGrow(GameObject plant)
    {
        plant.transform.localScale = new Vector3(x + 1, y + 2, z + 1);
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
        if (ground.gameObject.tag == "box" && plantIsHere == false) 
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
            general = babyCab;
            general2 = cabbage;
            //Destroy(GameObject.FindWithTag("box"));
            GameObject tmp = GameObject.FindWithTag("box");
            Destroy(tmp);
            plantIsHere = true; 
       

            timer = 0.0f;
            timer2 = 0.0f;
}
        Debug.Log("someting did touch it");
    }
}
