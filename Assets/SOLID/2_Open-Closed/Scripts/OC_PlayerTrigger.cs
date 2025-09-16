using UnityEngine;

public class OC_PlayerTrigger : MonoBehaviour
{
    private Rigidbody rb;
    
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<OC_ISquareStep>(out OC_ISquareStep _ISquareStep))
        {
            _ISquareStep.Jump(rb);
        }
    }
}
