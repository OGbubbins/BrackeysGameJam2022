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
