using UnityEngine;

public class ajustarPantalla : MonoBehaviour
{
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        float altoVisible = Camera.main.orthographicSize * 2f;
        float aspecto = (float)Screen.width / Screen.height;
        float anchoVisible = altoVisible * aspecto;

        Vector2 tama�oSprite = sr.sprite.bounds.size;

        float scaleX = anchoVisible / tama�oSprite.x;
        float scaleY = altoVisible / tama�oSprite.y;

        float extra = 0.05f;

        transform.localScale = new Vector3(
            scaleX + extra,
            scaleY + extra,
            1);
    }
}
