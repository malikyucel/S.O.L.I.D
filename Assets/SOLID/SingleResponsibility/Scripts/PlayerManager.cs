using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("References")]
    private PlayerInputs _playerInputs;
    private PalyerMovement _palyerMovement;
    private S_PlayerAudio _playerAudio;

    void Awake()
    {
        _palyerMovement = GetComponent<PalyerMovement>();
        _playerInputs = GetComponent<PlayerInputs>();
        _playerAudio = GetComponent<S_PlayerAudio>();
    }

    void Start()
    {
        _playerInputs.PlayerInputEnable();
    }

    void Update()
    {
        _palyerMovement.Movement(_playerInputs.GetMovementInput());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<S_PathSpawn>(out var pathSpawn))
        {
            pathSpawn.PathSpawn();
        }

        if (other.gameObject.TryGetComponent<S_SceneRestart>(out var sceneRestart))
        {
            _palyerMovement.StopMovement();
            _playerAudio.PlayLostSound();
            _playerInputs.PlayerInputDisable();
            sceneRestart.RestartScene();
        }
    }

    void OnEnable()
    {
        _playerInputs.PlayerInputEnable();
    }
    void OnDisable()
    {
        _playerInputs.PlayerInputDisable();
    }
}
