using UnityEngine;

public class ajustarPantalla : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        float altoVisible = Camera.main.orthographicSize * 2f;
        float aspecto = (float)Screen.width / Screen.height;
        float anchoVisible = altoVisible * aspecto;

        Vector2 tamañoSprite = sr.sprite.bounds.size;

        float scaleX = anchoVisible / tamañoSprite.x;
        float scaleY = altoVisible / tamañoSprite.y;

        float extra = 0.05f;

        transform.localScale = new Vector3(
            scaleX + extra,
            scaleY + extra,
            1);
    }
}
