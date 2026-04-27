using UnityEngine;

public class ObstacleDebug : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Pokeball chocó con: " + collision.gameObject.name);
        Debug.Log("Mi tag es: " + gameObject.tag);
    }
}