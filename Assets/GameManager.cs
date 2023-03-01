using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource click1; //Bar Click
    public AudioSource click2; //Beat Click
    public RythmScript rythmScript;
    public bool startPlaying;
    public float trackTime;
    public float barTime = 0; //Track Bars
    public double beatTime = 0; //Track Beats (1-4)
    public float BPM = 60





    // Start is called before the first frame update
    void Start()
    {
        //Play Bar Click on inital Start
        click1.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //Track the Bars
        trackTime += Time.deltaTime;
        if (trackTime >= barTime)
        {
            Debug.Log(barTime);
            click2.Play();
            barTime++;
        }
        //Track the Beats 
        //Tracktime / 4 for 4 beats in the Bar
        if (trackTime >= beatTime)
        {
            Debug.Log(beatTime);
            click1.Play();
            beatTime = beatTime + 0.25;
        }

     

            
        
    }
}
