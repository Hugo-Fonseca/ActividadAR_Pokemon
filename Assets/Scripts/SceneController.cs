using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void IrAEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void VolverInicio()
    {
        SceneManager.LoadScene("EscenaInicio");
    }
}