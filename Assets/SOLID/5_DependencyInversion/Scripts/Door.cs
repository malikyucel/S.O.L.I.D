using DG.Tweening;
using UnityEngine;

public class Door : MonoBehaviour, IActive
{
    private bool isActive;
    public bool IsActive => isActive;

    public void Active()
    {
        if (!isActive)
        {
            Activate();
            isActive = !isActive;
            return;
        }
        else
        {
            Deactivate();
            isActive = !isActive;
            return;
        }
    }

    public void Activate()
    {
        Vector3 rotate = new Vector3(0f, 65f, 0);
        transform.DORotate(rotate, 2f);
    }

    public void Deactivate()
    {
        Vector3 rotate = new Vector3(0f, 0f, 0);
        transform.DORotate(rotate, 2f);
    }
}
