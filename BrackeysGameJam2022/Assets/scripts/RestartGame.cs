using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartGame : MonoBehaviour
{
    public void restartlevel()
    {
        SceneManager.LoadScene(1);
    }
}
