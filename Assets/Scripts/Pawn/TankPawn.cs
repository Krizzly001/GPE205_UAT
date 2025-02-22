using UnityEngine;

// Inheriting pawn so it alows us to store different variable values
public class TankPawn : Pawn
{
    // Override every function or abstract

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        mover = GetComponent<Mover>();
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }


    // Override because changing the information in the parent
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
