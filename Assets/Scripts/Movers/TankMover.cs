using UnityEngine;

//Inherits: Mover(Parent)
public class TankMover : Mover
{
    private Rigidbody rb; // Variable for Rigidbody/HasPhysics, making a component
    private Transform tf; //

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Start()
    {
        //Get Rigidbody component
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }


    
    // Override: changing the information in the function
    public override void Move(Vector3 direction, float speed)
    {
        // Vector3 (Where its moving) = Normalize.Direction(Scalable to the game 0-1) MULTIPLY to the correct speed 
        //                              MULTIPLE deltatime(Moves every framrate your computer handles)
        Vector3 moveVector = direction.normalized * speed * Time.deltaTime;

        // NewPosition(Current RigidBody position + Where to move RigitBody)
        rb.MovePosition(rb.position + moveVector);

    }
    public override void Rotate(float turnSpeed)
    {
        tf.Rotate(0, turnSpeed * Time.deltaTime, 0);
    }
}
