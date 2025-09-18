using DG.Tweening;
using UnityEngine;

public class Boom : MonoBehaviour,IActive
{
    private bool isActive;
    public bool IsActive => isActive;
    Vector3 startScale, startPos;

    private void Start()
    {
        startScale = transform.localScale;
        startPos = transform.position;
    }

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
        transform.DOMoveY(startPos.y - 5f, 1f).OnComplete(() =>
        {
            transform.DOScale(3f, 2f)
                .SetLoops(-1, LoopType.Yoyo);
        });
        
    }

    public void Deactivate()
    {
        DOTween.Kill(transform, true);

        transform.position = startPos;
        transform.localScale = startScale;
    }
}
