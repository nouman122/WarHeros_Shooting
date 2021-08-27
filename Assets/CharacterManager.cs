using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CharacterManager : MonoBehaviour
{
    public GameObject[] BuyAgainbtn;
    public GameObject[] Btns, selected;
    public int result;
    public Text ScoreText;
    public int Char1Price = 20;
    public int Char2Price = 40;
    public int Char3Price = 60;
    public int Char4Price = 60;
    public int Char5Price = 60;
    public int Char6Price = 60;
    public int Char7Price = 60;
    public int Char8Price = 60;
    public int Char9Price = 60;
    public int Char10Price = 60;

    // Start is called before the first frame update
    void Start()
    {
        //  result = PlayerPrefs.GetInt("BuyPoints", PlayerController.buypoints);

        //  PlayerPrefs.SetInt("Result", result);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Launch1") == 1)
        {
            Btns[0].SetActive(false);

        }
        if (PlayerPrefs.GetInt("Launch2") == 1)
        {
            Btns[1].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch3") == 1)
        {
            Btns[2].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch4") == 1)
        {
            Btns[3].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch5") == 1)
        {
            Btns[4].SetActive(false);

        }
        if (PlayerPrefs.GetInt("Launch6") == 1)
        {
            Btns[5].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch7") == 1)
        {
            Btns[6].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch8") == 1)
        {
            Btns[7].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch9") == 1)
        {
            Btns[8].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Launch10") == 1)
        {
            Btns[9].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Char1") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(true);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char2") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(true);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);


        }
        else if (PlayerPrefs.GetInt("Char3") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(true);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char4") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(true);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char5") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(true);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char6") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(true);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char7") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(true);
            selected[8].SetActive(false);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char8") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(true);
            selected[9].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char9") == 1)
        {
            selected[0].SetActive(false);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Default") == 1)
        {
            selected[0].SetActive(true);
            selected[1].SetActive(false);
            selected[2].SetActive(false);
            selected[3].SetActive(false);
            selected[4].SetActive(false);
            selected[5].SetActive(false);
            selected[6].SetActive(false);
            selected[7].SetActive(false);
            selected[8].SetActive(false);
            selected[9].SetActive(false);

        }
        ScoreText.text = PlayerPrefs.GetInt("TotalPoint", PointManager.buypoint).ToString();
    }

    public void BuyChar1()
    {
        if (PointManager.buypoint >= Char1Price)
        {
            Debug.Log("Buy1");
            BuyAgainbtn[1].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char1Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);          //  PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char1", 1);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch1", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar2()
    {
        if (PointManager.buypoint >= Char2Price)
        {
            BuyAgainbtn[2].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char2Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            //PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char2", 1);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch2", 1);

            Debug.Log("Bought");

        }
    }
    public void BuyChar3()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char3Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[3].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char3Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 1);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch3", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar4()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char4Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[4].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char4Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 1);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch5", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar5()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char5Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[5].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char5Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 1);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch6", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar6()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char6Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[5].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char6Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 1);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch7", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar7()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char7Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[6].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char7Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 1);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch8", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar8()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char8Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[7].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char8Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 1);
            PlayerPrefs.SetInt("Char9", 0);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch9", 1);


            Debug.Log("Bought");

        }
    }
    public void BuyChar9()
    {
        Debug.Log("buy" + PointManager.buypoint);

        if (PointManager.buypoint >= Char9Price)
        {
            Debug.Log("buy");
            BuyAgainbtn[8].SetActive(true);

            PointManager.buypoint = PointManager.buypoint - Char9Price;
            PlayerPrefs.SetInt("TotalPoint", PointManager.buypoint);
            // PlayerPrefs.SetInt("Result", result);
            PlayerPrefs.SetInt("Char3", 0);
            PlayerPrefs.SetInt("Char2", 0);
            PlayerPrefs.SetInt("Char1", 0);
            PlayerPrefs.SetInt("Char4", 0);
            PlayerPrefs.SetInt("Char5", 0);
            PlayerPrefs.SetInt("Char6", 0);
            PlayerPrefs.SetInt("Char7", 0);
            PlayerPrefs.SetInt("Char8", 0);
            PlayerPrefs.SetInt("Char9", 1);
            PlayerPrefs.SetInt("Default", 0);
            PlayerPrefs.SetInt("Launch10", 1);


            Debug.Log("Bought");

        }
    }
    public void SelectDefault()
    {
        BuyAgainbtn[0].SetActive(true);

        PlayerPrefs.SetInt("Default", 1);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Launch4", 1);

    }
    public void Select1()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 1);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select2()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char2", 1);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select3()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char3", 1);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select4()
    {
        PlayerPrefs.SetInt("Default", 1);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select5()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 1);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select6()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 1);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select7()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 1);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select8()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 1);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select9()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 1);
        PlayerPrefs.SetInt("Char9", 0);
    }
    public void Select10()
    {
        PlayerPrefs.SetInt("Default", 0);
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 1);
    }

    public void OnBuyAgain1()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 1);
        selected[0].SetActive(true);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain2()
    {
        PlayerPrefs.SetInt("Char1", 1);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);
        selected[0].SetActive(false);
        selected[1].SetActive(true);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain3()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 1);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);
        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(true);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain4()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 1);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);
        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(true);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);
    }
    public void OnBuyAgain5()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 1);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(true);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain6()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 1);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(true);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain7()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 1);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(true);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain8()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 1);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(true);
        selected[8].SetActive(false);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain9()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 1);
        PlayerPrefs.SetInt("Char9", 0);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(true);
        selected[9].SetActive(false);

    }
    public void OnBuyAgain10()
    {
        PlayerPrefs.SetInt("Char1", 0);
        PlayerPrefs.SetInt("Char2", 0);
        PlayerPrefs.SetInt("Char3", 0);
        PlayerPrefs.SetInt("Char4", 0);
        PlayerPrefs.SetInt("Char5", 0);
        PlayerPrefs.SetInt("Char6", 0);
        PlayerPrefs.SetInt("Char7", 0);
        PlayerPrefs.SetInt("Char8", 0);
        PlayerPrefs.SetInt("Char9", 1);
        PlayerPrefs.SetInt("Default", 0);

        selected[0].SetActive(false);
        selected[1].SetActive(false);
        selected[2].SetActive(false);
        selected[3].SetActive(false);
        selected[4].SetActive(false);
        selected[5].SetActive(false);
        selected[6].SetActive(false);
        selected[7].SetActive(false);
        selected[8].SetActive(false);
        selected[9].SetActive(true);

    }
}