using DG.Tweening;
using UnityEngine;

public class Boom : MonoBehaviour,IActive
{
    private bool isActive;
    public bool IsActive => isActive;

    public void Activate()
    {
        Debug.Log("Deactive");
        float yPos = transform.position.y;
        transform.DOMoveY(yPos -5f, 1f).OnComplete(() =>
        {
            transform.DOScale(3f, 2f)
                .SetLoops(-1, LoopType.Yoyo);
        });
            
    }

    public void Deactivate()
    {
        Debug.Log("Deactive");
    }
}
