using UnityEngine;

public class PawnTank : Pawn
{
    public void Start()
    {
        //Save my tank in my GameManager
        GameManager.instance.tanks.Add(this);

        // Do what all pawns do
        base.Start();
    }

    public void OnDestroy()
    {
        // Remove my tank from the GameManager list
        GameManager.instance.tanks.Remove(this);
    }
    
    public override void Move(Vector3 directionToMove)
    {
        // Tell mover to move
        mover.Move(directionToMove, moveSpeed);
    }

    public override void Rotate(Vector3 directionToMove)
    {
        mover.Rotate(directionToMove, turnSpeed);
    }

    public override void Shoot()
    {
        print("Tank Shoots!!!");
    }
   
}
