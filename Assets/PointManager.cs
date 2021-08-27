using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour
{
    public Text Pointscoretxt;
    public static int buypoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pointscoretxt.text = PlayerPrefs.GetInt("TotalPoint", buypoint).ToString();
        if (Levelup.Success)
        {
            buypoint = PlayerPrefs.GetInt("TotalPoint", buypoint) + 5;
            PlayerPrefs.SetInt("TotalPoint", buypoint);
            Levelup.Success = false;
        }
    }
}
