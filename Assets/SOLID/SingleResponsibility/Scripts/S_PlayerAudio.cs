using UnityEngine;

public class S_PlayerAudio : MonoBehaviour
{
    [Header("Sound")]
    [SerializeField] private AudioClip _lostsound;

    public void PlayLostSound()
    {
        AudioSource.PlayClipAtPoint(_lostsound, transform.position);
    }
}
