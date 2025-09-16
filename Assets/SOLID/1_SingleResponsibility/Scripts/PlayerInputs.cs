using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private PlayerInput _playerInput;

    void Awake()
    {
        _playerInput = new PlayerInput();
    }

    public Vector2 GetMovementInput()
    {
        return _playerInput.Player.Move.ReadValue<Vector2>();
    }

    public void PlayerInputEnable()
    {
        _playerInput.Enable();
    }

    public void PlayerInputDisable()
    {
        _playerInput.Disable();
    }
}
