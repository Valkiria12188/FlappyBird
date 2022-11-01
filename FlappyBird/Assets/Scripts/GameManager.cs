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

    void Start()
    {
        Time.timeScale = 1f;
    }


    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "Time: " + Mathf.Clamp(Mathf.CeilToInt(time), 0, int.MaxValue).ToString(); //zaokr�glanie czasu do g�ry, nie b�dzie przecinka, b�d� typu ca�kowitego
        
        if(time <= 0)
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

}
