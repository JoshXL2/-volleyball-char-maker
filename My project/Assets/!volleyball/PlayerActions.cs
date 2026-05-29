using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Volleyball ball;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ball.Set(transform);
        }

        if (Input.GetMouseButtonDown(0))
        {
            ball.Spike(transform.forward);
        }
    }
}