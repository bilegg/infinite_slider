using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMove playerMovement;
    public bool hasColided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            playerMovement.enabled = false;
            hasColided = true;
        } 
    }
}
