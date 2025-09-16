using UnityEngine;

public class PalyerMovement : MonoBehaviour
{
    [Header("References")]
    private CharacterController _characterController;

    [Header("Settings")]
    public float _forwardSpeed;
    public float _leftRightSpeed;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    public void Movement(Vector2 movementInput)
    {
        _characterController.Move(Vector3.forward * Time.deltaTime * _forwardSpeed);

        if (movementInput.x < 0)
        {
            _characterController.Move(Vector3.left * Time.deltaTime * _leftRightSpeed * -movementInput.x);
        }
        else if (movementInput.x > 0)
        {
            _characterController.Move(Vector3.right * Time.deltaTime * _leftRightSpeed * movementInput.x);
        }
    }
    public void StopMovement()
    {
        _forwardSpeed = 0;
        _leftRightSpeed = 0;
    }
}
