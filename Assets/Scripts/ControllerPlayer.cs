using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerPlayer : Controller
{
    public InputActionAsset inputActions;

    public override void MakeDecisions()
    {
        //throw new System.NotImplementedException();
        //TODO: Write this function to make the decision

        Vector2 movementVector = inputActions["Move"].ReadValue<Vector2>();

        pawn.Move(new Vector2(0, movementVector.y));
        pawn.Rotate(new Vector3(movementVector.x, 0));

        if(inputActions["Shoot"].triggered)
        {
            pawn.Shoot();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Enable my input actions
        inputActions.Enable();

        // Add this to the list of players
        GameManager.instance.players.Add(this);
    }

    public void OnDestroy()
    {
        // Remove this to the list of players
        
    }

    // Update is called once per frame
    public override void Update()
    {
        MakeDecisions();
    }

    
}
