using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideQuad : MonoBehaviour
{

    public GameObject q1, q2, q3;

    // Start is called before the first frame update
    void Start()
    {
        q1.GetComponent<Renderer>().enabled = false;
        q2.GetComponent<Renderer>().enabled = false;
        q3.GetComponent<Renderer>().enabled = false;
        Debug.Log("q disabled");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
