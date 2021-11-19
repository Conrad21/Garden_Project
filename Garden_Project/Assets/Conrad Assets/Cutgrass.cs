using UnityEngine;



public class Cutgrass : MonoBehaviour
{

    public int clockMultiplier = 1;
    public GameObject grass;
    public ParticleSystem grasscuttingeffect;
    private float waitTime = 90.0f;
    private float timer = 0.0f;
    public AudioSource snipSource;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = waitTime * clockMultiplier;
       

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer > waitTime)
        {
            //Debug.Log("in the if");
            timer = 0.0f;
            grasscomeback();

        }
    }
    private float delay = 0;

 

    void OnCollisionEnter(Collision cutter)
    {
        //Debug.Log(cutter.gameObject.tag);
        if ((cutter.gameObject.tag == "scythe") && (grass.activeInHierarchy))
        {
        
           
            grasscuttingeffect.Play();
            
            snipSource.pitch = Random.Range(0.8f, 1.5f);
            snipSource.volume = Random.Range(0.8f, 1.0f);
            snipSource.Play();
            //Debug.Log("chahahahahaha");

            grass.SetActive(false);
            
        }
    }


    void grasscomeback()
    {
        grass.SetActive(true);
    }

}
