using UnityEngine;

public class MouseRaycast : MonoBehaviour
{
    public float rayDistance = 100f;
    public LayerMask hitLayers;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, rayDistance, hitLayers))
            {
                if (hit.transform.TryGetComponent<IActive>(out IActive active))
                {
                    active.Active();
                }
            }
        }
    }
}