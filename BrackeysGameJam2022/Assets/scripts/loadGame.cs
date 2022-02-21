using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    public void loadLevel1()
    {
        SceneManager.LoadScene("Game");
    }
}
