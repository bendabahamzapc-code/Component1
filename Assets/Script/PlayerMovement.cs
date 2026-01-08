using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;

    public Vector2 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 directionH = Vector2.right * Input.GetAxisRaw("Horizontal");
        Vector2 directionV = Vector2.up * Input.GetAxisRaw("Vertical");
        transform.Translate(speed * directionH.x * Time.deltaTime, speed * directionV.y * Time.deltaTime, 0);
        transform.Translate(speed * directionV * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}