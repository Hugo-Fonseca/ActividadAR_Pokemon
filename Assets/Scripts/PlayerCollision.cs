using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player detectó: " + collision.gameObject.name);
        Debug.Log("Tag detectado: " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Perdiste");
            Destroy(gameObject);
        }
    }
}