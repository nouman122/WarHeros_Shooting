using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreManager : MonoBehaviour
{
    public Text ScoreText;
    public static int score;
    public int enemy;
    public GameObject LevelCompletePanel;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        PlayerPrefs.GetInt("Score", score);

    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyGPI.enemycount || EnemyGPI1.enemycount) {
            enemy +=1;
            EnemyGPI.enemycount = false;
            EnemyGPI1.enemycount = false;
        }
        if (Application.loadedLevelName == "Level01") {
            if (enemy >= 5 && score >= 4) {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level01", 1);
                Time.timeScale = 0f;
            }
        }
        else if (Application.loadedLevelName == "Level02")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level02", 1);
            }
        }
        else if (Application.loadedLevelName == "Level03")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level03", 1);
            }
        }
        else if (Application.loadedLevelName == "Level04")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level04", 1);
            }
        }
        else if (Application.loadedLevelName == "Level05")
        {
            if (enemy >= 10 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level05", 1);
            }
        }
        else if (Application.loadedLevelName == "Level06")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level06", 1);
            }
        }
        else if (Application.loadedLevelName == "Level07")
        {
            if (enemy >= 11 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level07", 1);
            }
        }
        else if (Application.loadedLevelName == "Level08")
        {
            if (enemy >= 12 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level08", 1);
            }
        }
        else if (Application.loadedLevelName == "Level09")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level09", 1);
            }
        }
        else if (Application.loadedLevelName == "Level10")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level10", 1);
            }
        }
        else if (Application.loadedLevelName == "Level11")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level11", 1);
            }
        }
        else if (Application.loadedLevelName == "Level12")
        {
            if (enemy >= 12 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level12", 1);
            }
        }
        else if (Application.loadedLevelName == "Level13")
        {
            if (enemy >= 14 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level13", 1);
            }
        }
        else if (Application.loadedLevelName == "Level14")
        {
            if (enemy >= 5 && score >= 7)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level14", 1);
            }
        }
        else if (Application.loadedLevelName == "Level15")
        {
            if (enemy >= 13 && score >= 11)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level15", 1);
            }
        }
        else if (Application.loadedLevelName == "Level16")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level16", 1);
            }
        }
        else if (Application.loadedLevelName == "Level17")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level17", 1);
            }
        }
        else if (Application.loadedLevelName == "Level18")
        {
            if (enemy >= 13 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level18", 1);
            }
        }
        else if (Application.loadedLevelName == "Level19")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level19", 1);
            }
        }
        else if (Application.loadedLevelName == "Level20")
        {
            if (enemy >= 5 && score >= 4)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level20", 1);
            }
        }
       else if (Application.loadedLevelName == "Level21")
        {
            if (enemy >= 5 && score >= 4)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level21", 1);
                Time.timeScale = 0f;
            }
        }
        else if (Application.loadedLevelName == "Level22")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level22", 1);
            }
        }
        else if (Application.loadedLevelName == "Level23")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level23", 1);
            }
        }
        else if (Application.loadedLevelName == "Level24")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level24", 1);
            }
        }
        else if (Application.loadedLevelName == "Level25")
        {
            if (enemy >= 10 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level25", 1);
            }
        }
        else if (Application.loadedLevelName == "Level26")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level26", 1);
            }
        }
        else if (Application.loadedLevelName == "Level27")
        {
            if (enemy >= 11 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level27", 1);
            }
        }
        else if (Application.loadedLevelName == "Level28")
        {
            if (enemy >= 12 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level28", 1);
            }
        }
        else if (Application.loadedLevelName == "Level29")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level29", 1);
            }
        }
        else if (Application.loadedLevelName == "Level30")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level30", 1);
            }
        }
        else if (Application.loadedLevelName == "Level31")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level31", 1);
            }
        }
        else if (Application.loadedLevelName == "Level32")
        {
            if (enemy >= 12 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level32", 1);
            }
        }
        else if (Application.loadedLevelName == "Level33")
        {
            if (enemy >= 14 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level33", 1);
            }
        }
        else if (Application.loadedLevelName == "Level34")
        {
            if (enemy >= 5 && score >= 7)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level34", 1);
            }
        }
        else if (Application.loadedLevelName == "Level35")
        {
            if (enemy >= 13 && score >= 11)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level35", 1);
            }
        }
        else if (Application.loadedLevelName == "Level36")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level36", 1);
            }
        }
        else if (Application.loadedLevelName == "Level37")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level37", 1);
            }
        }
        else if (Application.loadedLevelName == "Level38")
        {
            if (enemy >= 13 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level38", 1);
            }
        }
        else if (Application.loadedLevelName == "Level39")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level39", 1);
            }
        }
        else if (Application.loadedLevelName == "Level40")
        {
            if (enemy >= 5 && score >= 4)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level40", 1);
            }
        }
        else if (Application.loadedLevelName == "Level41")
        {
            if (enemy >= 5 && score >= 4)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level41", 1);
                Time.timeScale = 0f;
            }
        }
        else if (Application.loadedLevelName == "Level42")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level42", 1);
            }
        }
        else if (Application.loadedLevelName == "Level43")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level43", 1);
            }
        }
        else if (Application.loadedLevelName == "Level44")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level44", 1);
            }
        }
        else if (Application.loadedLevelName == "Level45")
        {
            if (enemy >= 10 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level45", 1);
            }
        }
        else if (Application.loadedLevelName == "Level46")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level46", 1);
            }
        }
        else if (Application.loadedLevelName == "Level47")
        {
            if (enemy >= 11 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level47", 1);
            }
        }
        else if (Application.loadedLevelName == "Level48")
        {
            if (enemy >= 12 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level48", 1);
            }
        }
        else if (Application.loadedLevelName == "Level49")
        {
            if (enemy >= 12 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level49", 1);
            }
        }
        else if (Application.loadedLevelName == "Level50")
        {
            if (enemy >= 7 && score >= 6)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level50", 1);
            }
        }
        else if (Application.loadedLevelName == "Level51")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level51", 1);
            }
        }
        else if (Application.loadedLevelName == "Level52")
        {
            if (enemy >= 12 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level52", 1);
            }
        }
        else if (Application.loadedLevelName == "Level53")
        {
            if (enemy >= 14 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level53", 1);
            }
        }
        else if (Application.loadedLevelName == "Level54")
        {
            if (enemy >= 5 && score >= 7)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level54", 1);
            }
        }
        else if (Application.loadedLevelName == "Level55")
        {
            if (enemy >= 13 && score >= 11)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level55", 1);
            }
        }
        else if (Application.loadedLevelName == "Level56")
        {
            if (enemy >= 7 && score >= 9)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level56", 1);
            }
        }
        else if (Application.loadedLevelName == "Level57")
        {
            if (enemy >= 10 && score >= 8)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level57", 1);
            }
        }
        else if (Application.loadedLevelName == "Level58")
        {
            if (enemy >= 13 && score >= 12)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level58", 1);
            }
        }
        else if (Application.loadedLevelName == "Level59")
        {
            if (enemy >= 11 && score >= 10)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level59", 1);
            }
        }
        else if (Application.loadedLevelName == "Level60")
        {
            if (enemy >= 5 && score >= 4)
            {
                LevelCompletePanel.SetActive(true);
                PlayerPrefs.SetInt("Level60", 1);
            }
        }
        ScoreText.text = Mathf.FloorToInt(PlayerPrefs.GetInt("Score", score)).ToString();

        if (coinCollection.getCoin) {
            score = PlayerPrefs.GetInt("Score", score) + 1;
            PlayerPrefs.SetInt("Score", score);
            PlayerPrefs.GetInt("Score", score);
            ScoreText.text = Mathf.FloorToInt(PlayerPrefs.GetInt("Score",score)).ToString();
            coinCollection.getCoin = false;
        }
    }
}
