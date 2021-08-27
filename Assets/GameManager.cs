using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GoogleMobileAds.Api;
public class GameManager : MonoBehaviour
{
  
    public GameObject[] stars;
    public GameObject GameSound;
   
    public GameObject PausePanel;
    public GameObject TipPanel;
    public bool adBool = true;
  
    //InterstitialAd interstitial;
    //   private BannerView banner;

    // Use this for initialization
    void Start()
    {
        TipPanel.SetActive(true);
       // Time.timeScale = 1.0f;
 
        adBool = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (MainMenu.Mute)
        {
            GameSound.GetComponent<AudioSource>().enabled = false;

        }
        else
        {
            GameSound.GetComponent<AudioSource>().enabled = true;
        }

    }
  
    public void NextButton()
    {
        scoreManager.score = 0;
        PlayerPrefs.SetInt("Score", scoreManager.score);
        PlayerPrefs.GetInt("Score", scoreManager.score);
        Time.timeScale = 1.0f;
        Application.LoadLevel(Application.loadedLevel + 1);

    }

    public void MainMenuButon()
    {
        Application.LoadLevel("MainMenu");
        Time.timeScale = 1.0f;

    }

    public void Restart()
    {
        scoreManager.score = 0;
        PlayerPrefs.SetInt("Score", scoreManager.score);
        PlayerPrefs.GetInt("Score", scoreManager.score);
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0f;
        AudioListener.pause = false;
    }

    public void ResumeButton()
    {
        PausePanel.SetActive(false);

        Time.timeScale = 1.0f;
    }

    public void Pause()
    {
        
        PausePanel.SetActive(true);
        Time.timeScale = 0.01f;

    }

    public void OnClose()
    {
        TipPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }



}
