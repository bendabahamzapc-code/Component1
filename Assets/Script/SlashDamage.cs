using UnityEngine;

public class SlashDamage : MonoBehaviour
{
    private int damage;
    public float lifetime = 0.2f;

    public void Init(int damageValue)
    {
        damage = damageValue;
    }

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        Stats stats = other.GetComponent<Stats>();
        if (stats != null)
        {
            stats.TakeDamage(damage);
        }
    }
}