using UnityEngine;

// Abstract: Can have child classes
public abstract class Pawn : MonoBehaviour //Parent
{
    // VARIABLES
    // Public: Developer can change the values
    // Private: Cant be modified

    public float moveSpeed;
    public float turnSpeed;
    

    public Mover mover;



    //BLUEPRINTS
    // When game start this runsw
    public virtual void Start()
    {

    }

    // Update is called once per frame
    public virtual void Update()
    {

    }

    // FUNCTION

    // Functions to Move and rotate
    // Abstract: Child class can override these functions

    public abstract void MoveFoward();

    public abstract void MoveBackward();

    public abstract void RotateClockwise();

    public abstract void RotateCounterClockwise();

}
