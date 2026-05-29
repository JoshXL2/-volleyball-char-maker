using UnityEngine;

public class InputTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E key works");
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left click works");
        }
    }
}