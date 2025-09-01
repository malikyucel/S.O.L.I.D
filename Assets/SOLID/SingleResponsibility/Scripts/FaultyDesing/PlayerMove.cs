using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private CharacterController _characterController;

    public float _forwardSpeed;
    public float _leftRightSpeed;

    public AudioClip _lostsound;
    private float spawnZ = 20f;
    private PlayerInput _playerInput;

    void Awake()
    {
        _characterController = GetComponent<CharacterController>();

        _playerInput = new PlayerInput();
        _playerInput.Enable();
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        _characterController.Move(Vector3.forward * Time.deltaTime * _forwardSpeed);

        Vector2 inputVector = _playerInput.Player.Move.ReadValue<Vector2>();

        if (inputVector.x < 0)
        {
            _characterController.Move(Vector3.left * Time.deltaTime * _leftRightSpeed * -inputVector.x);
        }
        else if (inputVector.x > 0)
        {
            _characterController.Move(Vector3.right * Time.deltaTime * _leftRightSpeed * inputVector.x);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            AudioSource.PlayClipAtPoint(_lostsound, transform.position);
            _forwardSpeed = 0;
            _leftRightSpeed = 0;
            Invoke("RestartLevel", .5f);
        }

        if (other.CompareTag("Ground"))
        {
            GameObject path = other.transform.parent.gameObject;
            Instantiate(path, new Vector3(0, 0, spawnZ), Quaternion.identity);
            spawnZ += 10f;
        }
    }

    private void RestartLevel()
    {
        _playerInput.Disable();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void OnEnable()
    {
        _playerInput.Enable();
    }

    void OnDisable()
    {
        _playerInput.Disable(); 
    }

}
