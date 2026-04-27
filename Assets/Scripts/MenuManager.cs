using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void CerrarJuego()
    {
        Debug.Log("Saliendo del juego..."); // Para probar en consola
        Application.Quit(); // Cierra la app
    }
}
