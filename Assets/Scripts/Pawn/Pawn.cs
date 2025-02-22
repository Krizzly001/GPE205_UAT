using UnityEngine;

// abstract is used here so that it can have children
public abstract class Pawn : MonoBehaviour
{

    // Public so designers can change the variable value
    // Variable for move speed
    public float moveSpeed;
    // Variable for turn speed
    public float turnSpeed;
    
    public Mover mover;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public virtual void Start()
    {
        
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }


    // Functions to Move and rotate
    // Be abstract because child might change the information in the function

    public abstract void MoveFoward();

    public abstract void MoveBackward();

    public abstract void RotateClockwise();

    public abstract void RotateCounterClockwise();

}
