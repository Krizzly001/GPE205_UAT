using UnityEngine;

public class Timer : MonoBehaviour
{

    // Variables

     public float timerDelay = 1.0f;
     private float nextEventTime; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nextEventTime = Time.time + timerDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextEventTime) 
        {
            Debug.Log("It’s me!");
            nextEventTime = Time.time + timerDelay;
        }
        
    }
}
