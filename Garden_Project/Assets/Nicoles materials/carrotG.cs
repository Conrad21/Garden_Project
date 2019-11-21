using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrotG : MonoBehaviour
{
    public GameObject physicsOn;
    public Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void turnonG()
    {
        physicsOn.GetComponent<Rigidbody>().useGravity = true;
        m_Collider = GetComponent<Collider>();
        m_Collider.enabled = enabled;
    }
}
