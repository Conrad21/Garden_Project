using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grow_and_shrink : MonoBehaviour
{
    public GameObject alias;
    public float x = 0.1f;
    public float y = 0.1f;
    public float z = 0.1f;
    public float x_pos = 0.1f;
    public float y_pos = 0.1f;
    public float z_pos = 0.1f;
    public void growShrink()
    {
        alias.transform.localScale = new Vector3(x, y, z);
        alias.transform.localPosition = new Vector3(x_pos, y_pos, z_pos);

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
