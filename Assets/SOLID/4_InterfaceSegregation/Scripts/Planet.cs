using UnityEngine;

public class Planet : MonoBehaviour, IRotatable
{
    [SerializeField] private float rotateSpeed;

    private void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);
    }
}
