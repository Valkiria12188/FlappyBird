using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Time Settings")]
    public TextMeshProUGUI timeText;
    public float time;

    private float timeValue;

    void Start()
    {
        Time.timeScale = 1f;
        GetPlayerTime();
    }


    void Update()
    {
        time += Time.deltaTime;
        PlayerPrefs.SetFloat("timeValue",time);
        timeText.text = "Time: " + Mathf.Clamp(Mathf.CeilToInt(time), 0, int.MaxValue).ToString(); //zaokr¹glanie czasu do góry, nie bêdzie przecinka, bêd¹ typu ca³kowitego

        if (time <= 0)
        {
            RestartLevel();
        } 
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void GetPlayerTime()
    {
        timeValue = PlayerPrefs.GetFloat("timeValue", 0);
    }
   

}

