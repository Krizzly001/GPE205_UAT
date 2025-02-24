using UnityEngine;

// Abstract: Can have child classes
public abstract class Mover : MonoBehaviour // Parent
{
    
    public abstract void Start();
    public abstract void Update();

    // Functions

    // Has Variables only for Move Function
    // Variables can be modified in child class
    public abstract void Move(Vector3 direction, float speed);
    public abstract void Rotate(float turnSpeed); 
}
