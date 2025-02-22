using UnityEngine;

// Abstract: Avalable to have child class, also the child can
//           change the information in the function
public abstract class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public abstract void Start();

    // Update is called once per frame
    public abstract void Update();

    public abstract void Move(Vector3 direction, float speed); //Variables for move function only also meaning direction and speed cna be changed

    public abstract void Rotate(float turnSpeed); 
}
