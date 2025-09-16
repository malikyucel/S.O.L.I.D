using UnityEngine;

public abstract class Springboard : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    public void Jump(Rigidbody rigidbody)
    {
        rigidbody.AddForce(Vector3.up * _jumpForce);
    }
}
