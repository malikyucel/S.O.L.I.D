using UnityEngine;

public class OC_SquareStep : Springboard
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            Jump(rb);
        }
    }
}
