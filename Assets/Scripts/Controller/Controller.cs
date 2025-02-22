using UnityEngine;

public abstract class Controller : MonoBehaviour
{

    // Variable to hold are pawn
    // This is the (pawn)/object we are controlling
    public Pawn pawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // We MIGHT over ride so we use virtual on are function
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }
    // abstract has no code in them BUT virtual MIGHT have code
    public abstract void ProcessInputs(); // Child can use it though

}
