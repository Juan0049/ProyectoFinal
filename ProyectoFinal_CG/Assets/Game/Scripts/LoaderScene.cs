using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderScene : MonoBehaviour
{
    [Header("Paneles del menú")]
    public GameObject panelMenuPrincipal;
    public GameObject panelInstrucciones;
    public GameObject panelControles;

    // Método para cambiar de escena
    public void LoaderScenes(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    // Activar el panel de instrucciones
    public void MostrarInstrucciones()
    {
        panelMenuPrincipal.SetActive(false);
        panelInstrucciones.SetActive(true);
        panelControles.SetActive(false);
    }

    // Activar el panel de controles
    public void MostrarControles()
    {
        panelMenuPrincipal.SetActive(false);
        panelInstrucciones.SetActive(false);
        panelControles.SetActive(true);
    }

    // Volver al menú principal
    public void VolverAlMenu()
    {
        panelInstrucciones.SetActive(false);
        panelControles.SetActive(false);
        panelMenuPrincipal.SetActive(true);
    }

    // Salir del juego (solo funciona en compilado)
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}
