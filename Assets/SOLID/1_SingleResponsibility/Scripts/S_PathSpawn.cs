using UnityEngine;

public class S_PathSpawn : MonoBehaviour
{
    public void PathSpawn()
    {
        GameObject path = transform.parent.gameObject;
        Instantiate(path, new Vector3(0, 0, transform.position.z + 10f), Quaternion.identity);
    }
}
