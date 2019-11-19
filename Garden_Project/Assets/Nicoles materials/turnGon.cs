using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnGon : MonoBehaviour
{
    public GameObject physicsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turnonG ()
    {
        physicsOn.GetComponent<Rigidbody>().useGravity = true;
    }
}
