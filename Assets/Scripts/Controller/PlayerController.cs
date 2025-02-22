using UnityEngine;

// Inherits Parent: Controller
public class PlayerController : Controller
{
    //KeyCode: Using Keyboard inputs variables
    public KeyCode moveFowardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        // "Listens" every frame draw for key inputs
        ProcessInputs();
        
        // Updates the screen
        base.Update();
    }



    public override void ProcessInputs()
    {
        if(Input.GetKey(moveFowardKey))
        {
            pawn.MoveFoward(); // If I press the key foward(W), I get my Pawn(TankPawn) and calls moveFoward function
        }
        if(Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }
        if(Input.GetKey(rotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }
        if(Input.GetKey(rotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
        
    }
}
