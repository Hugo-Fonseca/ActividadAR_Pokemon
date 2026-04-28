using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public float jumpForce = 5f;

    public void Jump()
    {
        if (IsGrounded())
        {
            PlayerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 0.1f);
    }
}