using DG.Tweening;
using UnityEngine;

public class Door : MonoBehaviour, IActive
{
    private bool isActive;
    public bool IsActive => isActive;

    public void Activate()
    {
        Vector3 rotate = new Vector3(0f, 65f, 0);
        transform.DORotate(rotate, 2f);
    }

    public void Deactivate()
    {
    }
}
