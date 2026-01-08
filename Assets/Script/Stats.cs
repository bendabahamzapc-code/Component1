using UnityEngine;

public class Stats : MonoBehaviour
{
    public int maxHP = 100;
    public int damage = 10;
    public int currentHP;

    public bool isPlayer = false;

    void Start()
    {
        currentHP = maxHP;
    }

    public void TakeDamage(int amount)
    {
        currentHP -= amount;

        if (currentHP <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (isPlayer)
        {
            GameManager.Instance.PlayerDied();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}