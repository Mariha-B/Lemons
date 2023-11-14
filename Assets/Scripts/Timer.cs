using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{ 
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject gameEndScreen;
    private float timer = 60f;


    private void Update()
    {
        Time.timeScale = 1;
        timer -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);
        timeText.text = "Time: " + string.Format("{0:00}:{1:00}", minutes, seconds);
        TimerStart();

    }

    private void TimerStart()
    {
        if (timer <= 0)
        {
            Destroy(timeText);
            gameEndScreen.SetActive(true);
            Time.timeScale = 0;
        }
       

    }


   
}
