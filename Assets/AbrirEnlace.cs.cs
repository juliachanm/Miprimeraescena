using UnityEngine;

public class AbrirEnlace : MonoBehaviour
{
    public string url;

    public void AbrirSitio()
    {
        Application.OpenURL(url);
    }
}

