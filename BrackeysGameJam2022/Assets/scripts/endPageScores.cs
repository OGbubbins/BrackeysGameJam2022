using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class endPageScores : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI Level1HS;
    [SerializeField] TMPro.TextMeshProUGUI Level2HS;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Level1HS.text = ("Level 1 High Score:" + PlayerPrefs.GetFloat("HighScoreLV1").ToString() + " s");
        Level2HS.text = ("Level 2 High Score:" + PlayerPrefs.GetFloat("HighScoreLV2").ToString() + " s");
    }

    public void retryLV1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void retryLV2()
    {
        SceneManager.LoadScene("Level 2");
    }
}
