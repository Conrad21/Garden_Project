using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeFruit : MonoBehaviour
{
    public GameObject physicsOn;
    public GameObject physicsOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void swapTheFruit()
    {

        if (!physicsOn.activeInHierarchy)
        {
            physicsOn.SetActive(true);
            physicsOff.SetActive(false);
        }
    }
}
