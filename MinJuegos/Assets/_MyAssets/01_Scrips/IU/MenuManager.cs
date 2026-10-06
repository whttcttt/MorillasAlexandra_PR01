using UnityEngine;
using UnityEngine.SceneManagement;
//Libreria para poder cambiar de escena

public class MenuManager : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}