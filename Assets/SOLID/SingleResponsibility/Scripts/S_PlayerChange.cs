using UnityEngine;

public class S_PlayerChange : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject solidPlayer;
    [SerializeField] private GameObject faultyPlayer;
    [SerializeField] private GameObject cameraObj;

    [Header("Settings")]
    [SerializeField] private KeyCode changeKey = KeyCode.T;

    void Start()
    {
        if(solidPlayer.activeSelf)
        {
            CameraPos(solidPlayer);
        }
        else
        {
            CameraPos(faultyPlayer);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(changeKey))
        {
            ChangePlayer();
        }
    }

    private void ChangePlayer()
    {
        solidPlayer.SetActive(!solidPlayer.activeSelf);
        faultyPlayer.SetActive(!faultyPlayer.activeSelf);

        if(solidPlayer.activeSelf)
        {
            CameraPos(solidPlayer);
        }
        else
        {
            CameraPos(faultyPlayer);
        }
    }

    private void CameraPos(GameObject activePlayerObj)
    {
        cameraObj.transform.SetParent(activePlayerObj.transform);
        cameraObj.transform.localPosition = new Vector3(0, 2f, -6);
        cameraObj.transform.localRotation = Quaternion.Euler(15, 0, 0);
    }
}
