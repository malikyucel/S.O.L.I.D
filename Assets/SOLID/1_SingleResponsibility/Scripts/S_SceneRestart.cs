using UnityEngine;
using UnityEngine.SceneManagement;

public class S_SceneRestart : MonoBehaviour
{
    public void RestartScene()
    {
        Invoke(nameof(ReloadScene), .5f);
    }
    
    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
