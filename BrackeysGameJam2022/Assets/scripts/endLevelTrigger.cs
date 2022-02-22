using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endLevelTrigger : MonoBehaviour
{
    public bool levelEnded = false;
    private void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter(Collider other)
    {
        levelEnded = true;
        loadNextScene();
    }
}
