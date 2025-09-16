using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ball : MonoBehaviour, IJumper
{
    private Rigidbody rb;

    [SerializeField] private float minForce;
    [SerializeField] private float maxForce;
    [SerializeField] private float rayDistance;
    [SerializeField] private LayerMask groundLayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Jump();
    }

    public void Jump()
    {
        if (Physics.Raycast(transform.position, Vector3.down, rayDistance, groundLayer))
        {
            Vector3 force = transform.up * Random.Range(minForce,maxForce);

            rb.linearVelocity = Vector3.zero;
            rb.linearVelocity = force;
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayDistance);
    }
}
