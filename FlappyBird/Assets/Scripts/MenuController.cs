using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    float timeRecord;

    void Update()
    {
        float timeRecord = PlayerPrefs.GetFloat("timeValue");
        timeText.text = "Time: " + Mathf.Clamp(Mathf.CeilToInt(timeRecord), 0, int.MaxValue).ToString(); //zaokr¹glanie czasu do góry, nie bêdzie przecinka, bêd¹ typu ca³kowitego

    }

    public void LoadLevel(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
