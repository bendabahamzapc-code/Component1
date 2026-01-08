using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject slashPrefab;

    public float spawnInterval = 5f;

    public Transform spawnPoint;

    private float timer;
    private Stats stats;

    void Start()
    {
        stats = GetComponent<Stats>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnSlash();
            timer = 0f;
        }
    }

void SpawnSlash()
{
    if (slashPrefab == null) return;

    Vector3 pos = spawnPoint != null ? spawnPoint.position : transform.position;
    GameObject slash = Instantiate(slashPrefab, pos, Quaternion.identity);

    SlashDamage slashDamage = slash.GetComponent<SlashDamage>();
    if (slashDamage != null)
    {
        slashDamage.Init(stats.damage);
    }
}
}

