using UnityEngine;

// Inheriting: Parent class Pawn
public class TankPawn : Pawn // Child
{
    

    // BLUEPRINTS
    public override void Start()
    {
        mover = GetComponent<Mover>();
    }

    public override void Update()
    {
        
    }


    // Override Pawn funtions to modify
    public override void MoveFoward()
    {
        //Debug.Log("Move Foward");
        mover.Move(transform.forward, moveSpeed);
    }

    public override void MoveBackward()
    {
        //Debug.Log("Move BackFoward");
        mover.Move(transform.forward, -moveSpeed);
    }

    public override void RotateClockwise()
    {
        //Debug.Log("Rotate Clockwise");
        mover.Rotate(turnSpeed);
    }

    public override void RotateCounterClockwise()
    {
        //Debug.Log("Rotate Counter Clockwise");
        mover.Rotate(-turnSpeed);
    }
}
