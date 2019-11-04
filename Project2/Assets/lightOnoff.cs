using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnoff : MonoBehaviour
{

    public GameObject light;


    public void lightonoff()
    {

        if (light.activeInHierarchy)
        {
            light.SetActive(false);
        }
        else if (!light.activeInHierarchy)
        {
            light.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
