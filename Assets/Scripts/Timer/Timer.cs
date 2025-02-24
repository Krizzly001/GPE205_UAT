using UnityEngine;
// Not a Parent
public class Timer : MonoBehaviour
{

    // VARIABLES

     public float timerDelay = 1.0f;
     private float nextEventTime; 

    // BLUEPRINTS

    
    void Start()
    {
        //              startgame + delayevery#second
        nextEventTime = Time.time + timerDelay; // 0 + 1 = 1
    }

    // Update is called once per frame
    void Update()
    {
        //    1 >= 1      0.5>=1.5
        if (Time.time >= nextEventTime) 
        {
            Debug.Log("It’s me!");
            nextEventTime = Time.time + timerDelay; // 0.5 + 1 = 1.5
        }
        
    }
}
