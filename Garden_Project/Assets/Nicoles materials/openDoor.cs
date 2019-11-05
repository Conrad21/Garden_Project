using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    public GameObject doorOpen;
    public GameObject doorClosed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovingDoor()
    {
        if (!doorOpen.activeInHierarchy)
        {
            doorOpen.SetActive(true);
            doorClosed.SetActive(false);
        }
        else if (doorOpen.activeInHierarchy)
        {
            doorOpen.SetActive(false);
            doorClosed.SetActive(true);
        }

    }
}
