using UnityEngine;

public abstract class Controller : MonoBehaviour
{
    [HideInInspector] public Pawn pawn;

    public abstract void MakeDecisions();

    // attaches a pawn to a controller
    public void Possess(Pawn pawnToPossess)
    {
        pawnToPossess.controller = this;
        this.pawn = pawnToPossess;
    }

    // unposses pawn to a controller
    public void Unpossess()
    {
        pawn.controller = null;
        pawn = null;
    }

    public abstract void Update();
}
