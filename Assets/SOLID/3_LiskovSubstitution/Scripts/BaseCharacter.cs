using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    public float speed;
    [SerializeField] private KeyCode _soundKey;
    [SerializeField] private AudioSource _audio;

    public abstract void Move(float speed);

    protected void Audio()
    {
        if (Input.GetKeyDown(_soundKey))
        {
            _audio.Play();
        }
    }
}
