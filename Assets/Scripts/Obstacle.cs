using UnityEngine;

public class Obstacle : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }
}
