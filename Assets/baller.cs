using UnityEngine;
using UnityEngine.InputSystem;

public class baller : MonoBehaviour
{
    public float force = 10f

    private Rigidbody rb;

    private Vector3 startposition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startposition transform.position;
        rb = GetComponent<Rigidbody>();






         
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float x = 0f;
        float z = 0f;
        Keyboard kb = Keyboard.current
        if (kb.wKey.isPressed) z = 1f
        if (kb.sKey.isPressed) z = -1f
        if (kb.aKey.isPressed) x = -1f
        if (kb.dKey.isPressed) x = 1f

        Vector3 direction = new Vector3(x, 0f, z).normalized;

        rb.AddForce(direction * force);
    }
}
