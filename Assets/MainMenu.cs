using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject ShopPanel;
    public GameObject GameSound;
    public GameObject SoundOnButton, SoundOffButton;
    public static bool Mute = false;
    // Start is called before the first frame update
    void Start()
    {
        SoundOnButton.SetActive(true);
        SoundOffButton.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mute)
        {
            GameSound.GetComponent<AudioSource>().enabled = false;
            SoundOffButton.SetActive(true);
        }
        else
        {
            GameSound.GetComponent<AudioSource>().enabled = true;
            SoundOnButton.SetActive(true);
            SoundOffButton.SetActive(false);


        }
    }
    public void Sound()
    {

        if (!Mute)
        {
            Mute = !Mute;
            //AudioListener.pause = true;
            //SoundOnButton.SetActive (false);
            //SoundOffButton.SetActive (true);
        }
        else
        {
            Mute = !Mute;
            //	AudioListener.pause = false;
            //SoundOnButton.SetActive (true);
            //SoundOffButton.SetActive (false);
        }
    }
    public void OnPlayGame() {
        Application.LoadLevel("LevelSelection");
    }
    public void OnShopPanel()
    {
        ShopPanel.SetActive(true);
    }
    public void BackShopPanel()
    {
        ShopPanel.SetActive(false);
    }
}
