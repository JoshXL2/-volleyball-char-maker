using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Volleyball : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 spawnPosition;

    public float setForce = 7f;
    public float spikeForce = 15f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spawnPosition = transform.position; // save starting position
    }

    public void Set(Transform player)
    {
        rb.linearVelocity = Vector3.zero;
        rb.AddForce(Vector3.up * setForce, ForceMode.Impulse);
    }

    public void Spike(Vector3 direction)
    {
        rb.linearVelocity = Vector3.zero;
        Vector3 spikeDir = direction + Vector3.down * 0.5f;
        rb.AddForce(spikeDir.normalized * spikeForce, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            RespawnBall();
        }
    }

    void RespawnBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = spawnPosition;
    }
}