using UnityEngine;

public class OC_PlayerController : MonoBehaviour
{
    [Header("Reference")]
    [SerializeField] private Transform _movementDiraction;
    private PlayerInput _playerInputs;
    private Rigidbody _playerRb;
    
    [Header("Settings")]
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _groundCheckRayDistance;
    [SerializeField] private LayerMask _groundLayer;
    private Vector2 _moveInput;
    
    private void Awake()
    {
        _playerInputs = new PlayerInput();
        _playerInputs.Enable();

        _playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (_moveInput == Vector2.zero && IsGroundCheck())
        {
            float playerLinearVelocityY = _playerRb.linearVelocity.y;
            _playerRb.linearVelocity = new Vector3(0f, playerLinearVelocityY, 0f);
        }
        else
        {
            Vector3 durationForward = _movementDiraction.forward;
            Vector3 durationRight = _movementDiraction.right;
            durationForward.y = 0f;
            durationRight.y = 0f;
            Vector3 movementDirection = durationForward * _moveInput.y + durationRight * _moveInput.x;
            _playerRb.AddForce(movementDirection.normalized * _walkSpeed, ForceMode.VelocityChange);
            if (_playerRb.linearVelocity.magnitude > _maxSpeed)
            {
                Vector3 linearVelocity = _playerRb.linearVelocity.normalized * _maxSpeed;
                _playerRb.linearVelocity = new Vector3(linearVelocity.x, _playerRb.linearVelocity.y, linearVelocity.z);
            }
        }
    }

    private void PlayerInput()
    {
        _moveInput = _playerInputs.Player.Move.ReadValue<Vector2>();
    }

    private bool IsGroundCheck()
    {
        return Physics.Raycast(transform.position, Vector3.down, _groundCheckRayDistance, _groundLayer);
    }
}
