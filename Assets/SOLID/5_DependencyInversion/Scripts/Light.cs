using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour, IActive
{
    private bool isActive;
    public bool IsActive => isActive;

    [SerializeField] private GameObject[] lights;

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
        StartCoroutine(LightsActivate(isActive));
    }

    public void Deactivate()
    {
        StartCoroutine(LightsActivate(isActive));
    }

    IEnumerator LightsActivate(bool objectActive)
    {
        for (int i = 0; i < lights.Length; i++)
        {
            transform.GetChild(i).gameObject.SetActive(!objectActive);
            yield return new WaitForSeconds(0.2f);
        }
    }
}
