using UnityEngine;

public class NavegacionUIScene : MonoBehaviour
{
    public GameObject seccionMenu;    // Panel del menú principal
    public GameObject seccionVolumen; // Panel de volumen
    public GameObject seccionIdioma;  // Panel de idioma

    // Muestra el panel del menú
    public void MostrarMenu()
    {
        seccionMenu.SetActive(true);
        seccionVolumen.SetActive(false);
        seccionIdioma.SetActive(false);
    }

    // Muestra el panel de volumen
    public void MostrarVolumen()
    {
        seccionMenu.SetActive(false);
        seccionVolumen.SetActive(true);
        seccionIdioma.SetActive(false);
    }

    // Muestra el panel de idioma
    public void MostrarIdioma()
    {
        seccionMenu.SetActive(false);
        seccionVolumen.SetActive(false);
        seccionIdioma.SetActive(true);
    }
}
