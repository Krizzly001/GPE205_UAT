using UnityEngine;

/// Inheriting: Parent class Pawn
public class TankMover : Mover // Child
{
    // VARIABLES
    // Holds are Rigidbody and Transform
    private Rigidbody rb; 
    private Transform tf; 

    // BLUEPRINTS

    // Modifying
    public override void Start()
    {
        // Get are tanks rigidbody(mass, gravity & force) and tranform(position, rotation & scale)
        // Place into are variables
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    public override void Update()
    {
        
    }

    // FUNCTIONS
    // Override: gets are Mover funtions to modify

    public override void Move(Vector3 direction, float speed)
    {
        // Vector3 (Where its moving) = 
        //                              Normalize.Direction(Scalable to the game 0-1/Maintain direction) 
        //                            * to the correct speed 
        //                            * deltatime(Moves every framerate your computer handles)
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;

        // NewPosition(Current RigidBody position + Where to move RigitBody)
        rb.MovePosition(rb.position + moveVector);

    }

    public override void Rotate(float turnSpeed)
    {
        // Rotate(X, Y, Z)
        // Y: Controls turns(left/right)
        // Never tilt or rolls here

        tf.Rotate(0, turnSpeed * Time.deltaTime, 0);

    }
}
