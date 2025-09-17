using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour, IActive
{
    private bool isActive;
    public bool IsActive => isActive;

    [SerializeField] private GameObject[] lights;

    public void Activate()
    {
        StartCoroutine(LightsActivate());
    }

    public void Deactivate()
    {
    }

    IEnumerator LightsActivate()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
