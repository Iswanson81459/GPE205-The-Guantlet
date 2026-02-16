using UnityEngine;

public class MoverTank : Mover
{
    private Pawn pawn;

    private Rigidbody rb;

    public void Start()
    {
        pawn = GetComponent<Pawn>();
        rb = GetComponent<Rigidbody>();
    }

    public override void Move(Vector2 moveDirection, float moveSpeed)
    {
        Vector3 moveVector = new Vector3(moveDirection.x, 0, moveDirection.y);
        moveVector = transform.TransformDirection(moveVector);

        rb.MovePosition(rb.position + (moveVector * (pawn.moveSpeed * Time.deltaTime)));
    }

    public override void Rotate(Vector2 rotateDirection, float turnSpeed)
    {
        transform.Rotate(0, rotateDirection.x * (pawn.turnSpeed * Time.deltaTime), 0);
    }
}
