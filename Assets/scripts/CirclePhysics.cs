using UnityEngine;

public class CirclePhysics : MonoBehaviour
{

    private Rigidbody2D rb;

    [SerializeField] private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    public void setPhysicsSimulation(bool value)
    {
        if(rb != null)
        {
            rb.simulated = value;
        }
        else
        {
            Debug.LogError("Rigidbody2D not found :" + this);
        }
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        rb.linearVelocity = Vector3.zero;
    }

}
