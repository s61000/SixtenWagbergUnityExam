using UnityEngine;

public class Fireball : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 10f;     // How fast the fireball travels
    public float lifetime = 5f;   // How long before it destroys itself

    private Rigidbody rb;

    void Start()
    {
        // Get Rigidbody if it exists
        rb = GetComponent<Rigidbody>();

        // If object has a Rigidbody, use physics movement
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed;
        }
    }

    void Update()
    {
        // If there is NO Rigidbody, move manually
        if (rb == null)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        // Destroy after time has passed
        lifetime -= Time.deltaTime;
        if (lifetime <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
