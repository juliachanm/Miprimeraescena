using UnityEngine;
using UnityEngine.UI;

public class NavegacionUI : MonoBehaviour
{
    public GameObject PanelMenu;  // Sección para el menú principal
    public GameObject PanelVolumen;  // Sección para el volumen
    public GameObject PanelIdioma;  // Sección para el idioma

    public Slider sliderVolumen;  // Slider de volumen

    private void Start()
    {
        // Establece el slider al volumen actual del sistema
        if (sliderVolumen != null)
        {
            sliderVolumen.value = AudioListener.volume;  // Configura el volumen del sistema
            sliderVolumen.onValueChanged.AddListener(CambiarVolumen);  // Cambia volumen con el slider
        }
    }

    // Mostrar el menú principal
    public void MostrarMenu()
    {
        PanelMenu.SetActive(true);  // Activa el panel de menú
        PanelVolumen.SetActive(false);  // Desactiva el panel de volumen
        PanelIdioma.SetActive(false);  // Desactiva el panel de idioma
    }

    // Mostrar el panel de volumen
    public void MostrarVolumen()
    {
        PanelMenu.SetActive(false);  // Desactiva el panel de menú
        PanelVolumen.SetActive(true);  // Activa el panel de volumen
        PanelIdioma.SetActive(false);  // Desactiva el panel de idioma
    }

    // Mostrar el panel de idioma
    public void MostrarIdioma()
    {
        PanelMenu.SetActive(false);  // Desactiva el panel de menú
        PanelVolumen.SetActive(false);  // Desactiva el panel de volumen
        PanelIdioma.SetActive(true);  // Activa el panel de idioma
    }

    // Cambiar el volumen en función del valor del slider
    public void CambiarVolumen(float valor)
    {
        AudioListener.volume = valor;  // Cambia el volumen global
    }
}
