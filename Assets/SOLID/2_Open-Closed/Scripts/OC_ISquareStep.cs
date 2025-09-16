using UnityEngine;

public class OC_ISquareStep : MonoBehaviour, ISpringboard
{
    [SerializeField] private float _jumpForce = 400f;
    public void Jump(Rigidbody rigidbody)
    {
        rigidbody.AddForce(Vector3.up * _jumpForce);
    }
}
