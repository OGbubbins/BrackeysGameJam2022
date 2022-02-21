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
    public float startingTimeL1 = 60;
    public float startingTimeL2 = 60;
    public float startingTimeL3 = 60;

    //end times for each level
    public float endTimeL1;
    public float endTimeL2;
    public float endTimeL3;

    [SerializeField] TMPro.TextMeshProUGUI countdownText;

    void Start()
    {
        
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            currentTime = startingTimeL1;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            currentTime = startingTimeL2;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            currentTime = startingTimeL3;
        }
    }
    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        
        countdownText.text = "Time Remaining  " + Mathf.Round(currentTime).ToString();
        
        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }

    }
}
