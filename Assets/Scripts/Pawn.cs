using UnityEngine;

public abstract class Pawn : MonoBehaviour
{
    protected Mover mover;
    
    // Hides the variable from the inpsector/Design Team
    [HideInInspector]
    public Controller controller;

    public abstract void Move(Vector3 directionToMove);

    public abstract void Rotate(Vector3 direcitonToRotate);

    public abstract void Shoot();

    public float moveSpeed;
    public float turnSpeed;

    public Controller GetController() { return controller;}

    public void Start()
    {
        // Get the mover component
        mover = GetComponent<Mover>();
    }
}
