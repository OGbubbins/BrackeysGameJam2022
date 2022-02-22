using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    float currentTime;
    bool levelEnded;

    //max times for each level
    public float startingTime;

    //end times for each level
    public float endTime;

    [SerializeField] TMPro.TextMeshProUGUI countdownText;

    void Start()
    {
        currentTime = startingTime;
        levelEnded = GameObject.Find("EndGameTrigger").GetComponent<endLevelTrigger>().levelEnded;
    }
    private void Update()
    {
        levelEnded = GameObject.Find("EndGameTrigger").GetComponent<endLevelTrigger>().levelEnded;

        if (levelEnded == false)
        {
            currentTime -= 1 * Time.deltaTime;
        }
        else
        {
            endTime = startingTime -= Mathf.Round(currentTime);
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                if (endTime < PlayerPrefs.GetFloat("HighScoreLV1", 0))
                {
                    PlayerPrefs.SetFloat("HighScoreLV1", endTime);
                }
                PlayerPrefs.SetFloat("LevelTimeL1", startingTime);
            }

            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (endTime < PlayerPrefs.GetFloat("HighScoreLV2"))
                {
                    PlayerPrefs.SetFloat("HighScoreLV2", endTime);
                }
                PlayerPrefs.SetFloat("LevelTimeL2", startingTime);
            }

            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (endTime < PlayerPrefs.GetFloat("HighScoreLV3"))
                {
                    PlayerPrefs.SetFloat("HighScoreLV3", endTime);
                }
                PlayerPrefs.SetFloat("LevelTimeL3", startingTime);
            }

        }
        
        countdownText.text = "Time Remaining  " + Mathf.Round(currentTime).ToString();
        
        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }

    }
}
