using System.Collections;
using System.Diagnostics;
using System.Collections.Generic;
using UnityEngine;

public class UpdateHUD : MonoBehaviour
{

    //create a time containing object, it will be updated every update cycle
    public long timeElapsed;
    public Stopwatch stopwatch = new Stopwatch();
    public SimpleHealthBar healthBar;
    public int maxOxygen;
    public int currentOxygen;
    public GameObject q1, q2, q3;

    // Start is called before the first frame update
    void Start()
    {
        maxOxygen = 100;
        currentOxygen = 100;
        stopwatch.Start();
        q1.GetComponent<Renderer>().enabled = false;
        q2.GetComponent<Renderer>().enabled = false;
        q3.GetComponent<Renderer>().enabled = false;
        UnityEngine.Debug.Log("q hidden");

    }

    // Update is called once per frame
    void Update()
    {

        timeElapsed = stopwatch.ElapsedMilliseconds;
        if (timeElapsed%1000==0)
        {
            currentOxygen -= 10;
            healthBar.UpdateBar(currentOxygen, maxOxygen);
        }

        if(currentOxygen/maxOxygen < 0.5)
        {
            healthBar.UpdateColor(Color.yellow);
        }
        

    }
}
