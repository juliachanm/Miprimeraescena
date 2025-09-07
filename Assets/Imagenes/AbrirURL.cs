using UnityEngine;

public class AbrirURL : MonoBehaviour
{
    [SerializeField] private string url;

    public void Abrir()
    {
        Application.OpenURL(url);
    }
}
