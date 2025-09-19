using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    public Animator caballeroAnimator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            caballeroAnimator.SetTrigger("Attack");

            Destroy(gameObject, 0.4f);
        }
    }
}
