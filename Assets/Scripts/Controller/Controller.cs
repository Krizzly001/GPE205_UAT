using UnityEngine;

// Abstract: Can have child classes
public abstract class Controller : MonoBehaviour // Parent
{

    // VARIABLES
    // Gets pawn being controlled by user
    public Pawn pawn;

    // BLUEPRINTS
    
    // We MIGHT over ride so we use virtual
    public virtual void Start()
    {
        
    }

    public virtual void Update()
    {
        
    }

    //FUNCTIONS

    // Abstract: Can be modified by child class of this parent
    public abstract void ProcessInputs();

}
