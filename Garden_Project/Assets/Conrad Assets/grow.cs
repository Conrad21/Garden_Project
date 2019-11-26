using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow : MonoBehaviour
{
    public GameObject cabbage;
  //public GameObject carrot;
    //public GameObject lettuse;
    //public GameObject flower1;
   /// public GameObject pumpkin;
    public GameObject ground;
    public float waitTime = 1.0f;
    private float timer = 0.0f;
    public float x = 1;
    public float y = 1;
    public float z = 1;
    GameObject general;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer > waitTime)
        {
            Debug.Log("in the if");
            timer = timer - waitTime;
            plantGrow();

        }

    }
    public void plantGrow()
    {
        general.transform.localScale = new Vector3(x + 1, y + 2, z + 1);
    }


    void OnCollisionEnter(Collision ground)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (ground.gameObject.name == "dirt")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Do something here");

        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (ground.gameObject.tag == "box")
        {
           //If the GameObject has the same tag as specified, output this message in the console
           Debug.Log("Do something else here");
            general = cabbage;
        }
        Debug.Log("someting did touch it");
    }
}


