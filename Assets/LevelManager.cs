using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float timer=3f;
    public GameObject GameSound;

    public GameObject LoadingPanel;

	public bool adBool=true;
    //	public GameObject TipPanel,TipPanel1,TipPanel2,TipPanel3,TipPanel4,TipPanel5,TipPanel6,TipPanel7,TipPanel8,TipPanel9,TipPanel10,TipPanel11,TipPanel12,TipPanel13,TipPanel14,TipPanel15,TipPanel16,TipPanel17,TipPanel18,TipPanel19,TipPanel20;
    public Sprite leveltwo, levelthree, levelfour, levelfive, levelsix, levelseven, leveleight, levelnine, levelten, leveleleven,
    leveltwelve, levelthirteen, levelfourteen, levelfifteen, levelsixteen, levelseventeen,
    leveleighteen, levelninteen, leveltwenty, leveltwentyone, leveltwentytwo, leveltwentythree, leveltwentyfour, leveltwentyfive, leveltwentysix, leveltwentyseven, leveltwentyeight
        , leveltwentynine, levelthirty, levelthirtyonoe, levelthirtytwo, levelthirtythree, levelthirtyfour, levelthirtyfive, levelthirtysix, levelthirtyseven, levelthirtyeight, levelthirtynine, levelfourty,
        levelfourtyone, levelfourtytwo, levelfourtythree, levelfourtyfour, levelfourtyfive, levelfourtysix, levelfourtyseven, levelfourtyeight, levelfourtynine, levelfifity
        , levelfifityone, levelfifitytwo, levelfifitythree, levelfifityfour, levelfifityfive, levelfifitysix, levelfifityseven, levelfifityeight
        , levelfifitynine, levelsixty;


    public Button leveltwobtn, levelthreebtn, levelfourbtn, levelfivebtn, levelsixbtn, levelsevenbtn, leveleightbtn, levelninebtn, leveltenbtn, levelelevenbtn,
    leveltwelvebtn, levelthirteenbtn, levelfourteenbtn, levelfifteenbtn, levelsixteenbtn, levelseventeenbtn,
    leveleighteenbtn, levelninteenbtn, leveltwentybtn, leveltwentyonebtn, leveltwentytwobtn, leveltwentythreebtn, leveltwentyfourbtn, leveltwentyfivebtn, leveltwentysixbtn, leveltwentysevenbtn,
        leveltwentyeightbtn, leveltwentyninebtn, levelthirtybtn, levelthirtyonebtn, levelthirtytwobtn, levelthirtythreebtn, levelthirtyfourbtn, levelthirtyfivebtn, levelthirtysixbtn,
        levelthirtysevenbtn, levelthirtyeightbtn, levelthirtyninebtn, levelfourtybtn, levelfourtyonebtn, levelfourtytwobtn, levelfourtythreebtn
        , levelfourtyfourbtn, levelfourtyfivebtn, levelfourtysixbtn, levelfourtysevenbtn, levelfourtyeightbtn, levelfourtyninebtn, levelfiftybtn
        , levelfiftyonebtn, levelfiftytwobtn, levelfiftythreebtn, levelfiftyfourbtn, levelfiftyfivebtn, levelfiftysixbtn, levelfiftysevenbtn, levelfiftyeightbtn
        , levelfiftyninebtn, levelsixtybtn;
    // Use this for initialization
    void Start () {

        if (MainMenu.Mute)
        {
            GameSound.GetComponent<AudioSource>().enabled = false;

        }
        else
        {
            GameSound.GetComponent<AudioSource>().enabled = true;
        }

        checklevelfirst ();
		checklevelsecond ();
		checklevelthird ();
		checklevelfourth ();
		checklevelfive ();
		checklevelsix ();
		checklevelseven ();
		checkleveleight ();
		checklevelnine ();
        checklevelten();
        checkleveleleven();
        checkleveltwelve();
        checklevelthirteen();
        checklevelfourteen();
        checklevelfifteen();
        checklevelsexteen();
        checklevelseventeen();
        checkleveleighteen();
        checklevelnineteen();
        checkleveltwenty();
        checkleveltwentyone();
        checkleveltwentytwo();
        checkleveltwentythree();
        checkleveltwentyfour();
        checkleveltwentyfive();
        checkleveltwentysix();
        checkleveltwentyseven();
        checkleveltwentyeight();
        checkleveltwentynine();
        checklevelthirty();
        checklevelthirtyOne();
        checklevelthirtytwo();
        checklevelthirtythree();
        checklevelthirtyfour();
        checklevelthirtyfive();
        checklevelthirtysix();
        checklevelthirtyseven();
        checklevelthirtyeight();
        checklevelthirtynine();
        checklevelfourty();
        checklevelfourtyone();
        checklevelfourtytwo();
        checklevelfourtythree();
        checklevelfourtytfour();
        checklevelfourtytfive();
        checklevelfourtytsix();
        checklevelfourtytseven();
        checklevelfourtyteight();
        checklevelfourtytnine();
        checklevelfifty();
        checklevelfiftyone();
        checklevelfiftytwo();
        checklevelfiftythree();
        checklevelfiftyfour();
        checklevelfiftyfive();
        checklevelfiftysix();
        checklevelfiftyseven();
        checklevelfiftyeight();
        checklevelfiftynine();
        checklevelsixty();



    }

	// Update is called once per frame
	void Update () {

	}
	public void changeleveltwotx()
	{
		leveltwobtn.image.sprite = leveltwo;
	}
	public void changelevelthreetx()
	{
		levelthreebtn.image.sprite = levelthree;
	}
	public void changelevelfourtx()
	{
		levelfourbtn.image.sprite = levelfour;
	}
	public void changelevelfivetx()
	{
		levelfivebtn.image.sprite = levelfive;
	}
	public void changelevelsixtx()
	{
		levelsixbtn.image.sprite = levelsix;
	}

	public void changelevelseventx()
	{
		levelsevenbtn.image.sprite = levelseven;
	}

	public void changeleveleighttx()
	{
		leveleightbtn.image.sprite = leveleight;
	}

	public void changelevelninetx()
	{
		levelninebtn.image.sprite = levelnine;
	}

    public void changeleveltentx()
    {
        leveltenbtn.image.sprite = levelten;
        leveltenbtn.image.color = new Color(leveltenbtn.image.color.r, leveltenbtn.image.color.g, leveltenbtn.image.color.b, 1f);
    }
    public void changeleveleleventx()
    {
        levelelevenbtn.image.sprite = leveleleven;
        levelelevenbtn.image.color = new Color(levelelevenbtn.image.color.r, levelelevenbtn.image.color.g, levelelevenbtn.image.color.b, 1f);
    }
    public void changeleveltwelvetentx()
    {
        leveltwelvebtn.image.sprite = leveltwelve;
        leveltwelvebtn.image.color = new Color(leveltwelvebtn.image.color.r, leveltwelvebtn.image.color.g, leveltwelvebtn.image.color.b, 1f);
    }
    public void changelevelthirteententx()
    {
        levelthirteenbtn.image.sprite = levelthirteen;
        levelthirteenbtn.image.color = new Color(levelthirteenbtn.image.color.r, levelthirteenbtn.image.color.g, levelthirteenbtn.image.color.b, 1f);
    }
    public void changelevelfourteentx()
    {
        levelfourteenbtn.image.sprite = levelfourteen;
        levelfourteenbtn.image.color = new Color(levelfourteenbtn.image.color.r, levelfourteenbtn.image.color.g, levelfourteenbtn.image.color.b, 1f);
    }
    public void changelevelfifiteentx()
    {
        levelfifteenbtn.image.sprite = levelfifteen;
        levelfifteenbtn.image.color = new Color(levelfifteenbtn.image.color.r, levelfifteenbtn.image.color.g, levelfifteenbtn.image.color.b, 1f);
    }
    public void changelevelsixteentx()
    {
        levelsixteenbtn.image.sprite = levelsixteen;
        levelsixteenbtn.image.color = new Color(levelsixteenbtn.image.color.r, levelsixteenbtn.image.color.g, levelsixteenbtn.image.color.b, 1f);
    }
    public void changelevelseventeentx()
    {
        levelseventeenbtn.image.sprite = levelseventeen;
        levelseventeenbtn.image.color = new Color(levelseventeenbtn.image.color.r, levelseventeenbtn.image.color.g, levelseventeenbtn.image.color.b, 1f);
    }
    public void changeleveleighteentx()
    {
        leveleighteenbtn.image.sprite = leveleighteen;
        leveleighteenbtn.image.color = new Color(leveleighteenbtn.image.color.r, leveleighteenbtn.image.color.g, leveleighteenbtn.image.color.b, 1f);
    }
    public void changelevelninteentx()
    {
        levelninteenbtn.image.sprite = levelninteen;
        levelninteenbtn.image.color = new Color(levelninteenbtn.image.color.r, levelninteenbtn.image.color.g, levelninteenbtn.image.color.b, 1f);
    }
    public void changeleveltwentytx()
    {
        leveltwentybtn.image.sprite = leveltwenty;
        leveltwentybtn.image.color = new Color(leveltwentybtn.image.color.r, leveltwentybtn.image.color.g, leveltwentybtn.image.color.b, 1f);
    }
    public void changeleveltwentyonetx()
    {
        leveltwentyonebtn.image.sprite = leveltwentyone;
        leveltwentyonebtn.image.color = new Color(leveltwentyonebtn.image.color.r, leveltwentyonebtn.image.color.g, leveltwentyonebtn.image.color.b, 1f);
    }
    public void changeleveltwentytwotx()
    {
        leveltwentytwobtn.image.sprite = leveltwentytwo;
        leveltwentytwobtn.image.color = new Color(leveltwentytwobtn.image.color.r, leveltwentytwobtn.image.color.g, leveltwentytwobtn.image.color.b, 1f);
    }
    public void changeleveltwenthreetx()
    {
        leveltwentythreebtn.image.sprite = leveltwentythree;
        leveltwentythreebtn.image.color = new Color(leveltwentythreebtn.image.color.r, leveltwentythreebtn.image.color.g, leveltwentythreebtn.image.color.b, 1f);
    }
    public void changeleveltwentyfourtx()
    {
        leveltwentyfourbtn.image.sprite = leveltwentyfour;
        leveltwentyfourbtn.image.color = new Color(leveltwentyfourbtn.image.color.r, leveltwentyfourbtn.image.color.g, leveltwentyfourbtn.image.color.b, 1f);
    }
    public void changeleveltwentyfivetx()
    {
        leveltwentyfivebtn.image.sprite = leveltwentyfive;
        leveltwentyfivebtn.image.color = new Color(leveltwentyfivebtn.image.color.r, leveltwentyfivebtn.image.color.g, leveltwentyfivebtn.image.color.b, 1f);
    }
    public void changeleveltwentysixtx()
    {
        leveltwentysixbtn.image.sprite = leveltwentysix;
        leveltwentysixbtn.image.color = new Color(leveltwentysixbtn.image.color.r, leveltwentysixbtn.image.color.g, leveltwentysixbtn.image.color.b, 1f);
    }
    public void changeleveltwentyseventx()
    {
        leveltwentysevenbtn.image.sprite = leveltwentyseven;
        leveltwentysevenbtn.image.color = new Color(leveltwentysevenbtn.image.color.r, leveltwentysevenbtn.image.color.g, leveltwentysevenbtn.image.color.b, 1f);
    }
    public void changeleveltweneighttx()
    {
        leveltwentyeightbtn.image.sprite = leveltwentyeight;
        leveltwentyeightbtn.image.color = new Color(leveltwentyeightbtn.image.color.r, leveltwentyeightbtn.image.color.g, leveltwentyeightbtn.image.color.b, 1f);
    }
    public void changeleveltwentyninetx()
    {
        leveltwentyninebtn.image.sprite = leveltwentynine;
        leveltwentyninebtn.image.color = new Color(leveltwentyninebtn.image.color.r, leveltwentyninebtn.image.color.g, leveltwentyninebtn.image.color.b, 1f);
    }
    public void changelevelthirtytx()
    {
        levelthirtybtn.image.sprite = levelthirty;
        levelthirtybtn.image.color = new Color(levelthirtybtn.image.color.r, levelthirtybtn.image.color.g, levelthirtybtn.image.color.b, 1f);
    }
    public void changelevelthirtyonetx()
    {
        levelthirtyonebtn.image.sprite = levelthirtyonoe;
        levelthirtyonebtn.image.color = new Color(levelthirtyonebtn.image.color.r, levelthirtyonebtn.image.color.g, levelthirtyonebtn.image.color.b, 1f);
    }
    public void changelevelthirtytwotx()
    {
        levelthirtytwobtn.image.sprite = levelthirtytwo;
        levelthirtytwobtn.image.color = new Color(levelthirtytwobtn.image.color.r, levelthirtytwobtn.image.color.g, levelthirtytwobtn.image.color.b, 1f);
    }
    public void changelevelthirtythreetx()
    {
        levelthirtythreebtn.image.sprite = levelthirtythree;
        levelthirtythreebtn.image.color = new Color(levelthirtythreebtn.image.color.r, levelthirtythreebtn.image.color.g, levelthirtythreebtn.image.color.b, 1f);
    }
    public void changelevelthirtyfourtx()
    {
        levelthirtyfourbtn.image.sprite = levelthirtyfour;
        levelthirtyfourbtn.image.color = new Color(levelthirtyfourbtn.image.color.r, levelthirtyfourbtn.image.color.g, levelthirtyfourbtn.image.color.b, 1f);
    }
    public void changelevelthirtyfivetx()
    {
        levelthirtyfivebtn.image.sprite = levelthirtyfive;
        levelthirtyfivebtn.image.color = new Color(levelthirtyfivebtn.image.color.r, levelthirtyfivebtn.image.color.g, levelthirtyfivebtn.image.color.b, 1f);
    }
    public void changelevelthirtysixtx()
    {
        levelthirtysixbtn.image.sprite = levelthirtysix;
        levelthirtysixbtn.image.color = new Color(levelthirtysixbtn.image.color.r, levelthirtysixbtn.image.color.g, levelthirtysixbtn.image.color.b, 1f);
    }
    public void changelevelthirtyseventx()
    {
        levelthirtysevenbtn.image.sprite = levelthirtyseven;
        levelthirtysevenbtn.image.color = new Color(levelthirtysevenbtn.image.color.r, levelthirtysevenbtn.image.color.g, levelthirtysevenbtn.image.color.b, 1f);
    }
    public void changelevelthirtyeighttx()
    {
        levelthirtyeightbtn.image.sprite = levelthirtyeight;
        levelthirtyeightbtn.image.color = new Color(levelthirtyeightbtn.image.color.r, levelthirtyeightbtn.image.color.g, levelthirtyeightbtn.image.color.b, 1f);
    }
    public void changelevelthirtyninetx()
    {
        levelthirtyninebtn.image.sprite = levelthirtynine;
        levelthirtyninebtn.image.color = new Color(levelthirtyninebtn.image.color.r, levelthirtyninebtn.image.color.g, levelthirtyninebtn.image.color.b, 1f);
    }
    public void changelevelfourtytx()
    {
        levelfourtybtn.image.sprite = levelfourty;
        levelfourtybtn.image.color = new Color(levelfourtybtn.image.color.r, levelfourtybtn.image.color.g, levelfourtybtn.image.color.b, 1f);
    }
    public void changelevelfourtyonetx()
    {
        levelfourtyonebtn.image.sprite = levelfourtyone;
        levelfourtyonebtn.image.color = new Color(levelfourtyonebtn.image.color.r, levelfourtyonebtn.image.color.g, levelfourtyonebtn.image.color.b, 1f);
    }
    public void changelevelfourtytwotx()
    {
        levelfourtytwobtn.image.sprite = levelfourtytwo;
        levelfourtytwobtn.image.color = new Color(levelfourtytwobtn.image.color.r, levelfourtytwobtn.image.color.g, levelfourtytwobtn.image.color.b, 1f);
    }
    public void changelevelfourtythreetx()
    {
        levelfourtythreebtn.image.sprite = levelfourtythree;
        levelfourtythreebtn.image.color = new Color(levelfourtythreebtn.image.color.r, levelfourtythreebtn.image.color.g, levelfourtythreebtn.image.color.b, 1f);
    }
    public void changelevelfourtyfourtx()
    {
        levelfourtyfourbtn.image.sprite = levelfourtyfour;
        levelfourtyfourbtn.image.color = new Color(levelfourtyfourbtn.image.color.r, levelfourtyfourbtn.image.color.g, levelfourtyfourbtn.image.color.b, 1f);
    }
    public void changelevelfourtyfivetx()
    {
        levelfourtyfivebtn.image.sprite = levelfourtyfive;
        levelfourtyfivebtn.image.color = new Color(levelfourtyfivebtn.image.color.r, levelfourtyfivebtn.image.color.g, levelfourtyfivebtn.image.color.b, 1f);
    }
    public void changelevelfourtysixtx()
    {
        levelfourtysixbtn.image.sprite = levelfourtysix;
        levelfourtysixbtn.image.color = new Color(levelfourtyfivebtn.image.color.r, levelfourtyfivebtn.image.color.g, levelfourtyfivebtn.image.color.b, 1f);
    }
    public void changelevelfourtyseventx()
    {
        levelfourtysevenbtn.image.sprite = levelfourtyseven;
        levelfourtysevenbtn.image.color = new Color(levelfourtysevenbtn.image.color.r, levelfourtysevenbtn.image.color.g, levelfourtysevenbtn.image.color.b, 1f);
    }
    public void changelevelfourtyeighttx()
    {
        levelfourtyeightbtn.image.sprite = levelfourtyeight;
        levelfourtyeightbtn.image.color = new Color(levelfourtyeightbtn.image.color.r, levelfourtyeightbtn.image.color.g, levelfourtyeightbtn.image.color.b, 1f);
    }
    public void changelevelfourtyninetx()
    {
        levelfourtyninebtn.image.sprite = levelfourtynine;
        levelfourtyninebtn.image.color = new Color(levelfourtyninebtn.image.color.r, levelfourtyninebtn.image.color.g, levelfourtyninebtn.image.color.b, 1f);
    }
    public void changelevelfiftytx()
    {
        levelfiftybtn.image.sprite = levelfifity;
        levelfiftybtn.image.color = new Color(levelfiftybtn.image.color.r, levelfiftybtn.image.color.g, levelfiftybtn.image.color.b, 1f);
    }
    public void changelevelfiftyOnetx()
    {
        levelfiftyonebtn.image.sprite = levelfifityone;
        levelfiftyonebtn.image.color = new Color(levelfiftyonebtn.image.color.r, levelfiftyonebtn.image.color.g, levelfiftyonebtn.image.color.b, 1f);
    }
    public void changelevelfiftyTwotx()
    {
        levelfiftytwobtn.image.sprite = levelfifitytwo;
        levelfiftytwobtn.image.color = new Color(levelfiftytwobtn.image.color.r, levelfiftytwobtn.image.color.g, levelfiftytwobtn.image.color.b, 1f);
    }
    public void changelevelfiftyThreetx()
    {
        levelfiftythreebtn.image.sprite = levelfifitythree;
        levelfiftythreebtn.image.color = new Color(levelfiftythreebtn.image.color.r, levelfiftythreebtn.image.color.g, levelfiftythreebtn.image.color.b, 1f);
    }
    public void changelevelfiftyFourtx()
    {
        levelfiftyfourbtn.image.sprite = levelfifityfour;
        levelfiftyfourbtn.image.color = new Color(levelfiftyfourbtn.image.color.r, levelfiftyfourbtn.image.color.g, levelfiftyfourbtn.image.color.b, 1f);
    }
    public void changelevelfiftyFivetx()
    {
        levelfiftyfivebtn.image.sprite = levelfifityfive;
        levelfiftyfivebtn.image.color = new Color(levelfiftyfivebtn.image.color.r, levelfiftyfivebtn.image.color.g, levelfiftyfivebtn.image.color.b, 1f);
    }
    public void changelevelfiftySixtx()
    {
        levelfiftysixbtn.image.sprite = levelfifitysix;
        levelfiftysixbtn.image.color = new Color(levelfiftysixbtn.image.color.r, levelfiftysixbtn.image.color.g, levelfiftysixbtn.image.color.b, 1f);
    }
    public void changelevelfiftySeventx()
    {
        levelfiftysevenbtn.image.sprite = levelfifityseven;
        levelfiftysevenbtn.image.color = new Color(levelfiftysevenbtn.image.color.r, levelfiftysevenbtn.image.color.g, levelfiftysevenbtn.image.color.b, 1f);
    }
    public void changelevelfiftyEighttx()
    {
        levelfiftyeightbtn.image.sprite = levelfifityeight;
        levelfiftyeightbtn.image.color = new Color(levelfiftyeightbtn.image.color.r, levelfiftyeightbtn.image.color.g, levelfiftyeightbtn.image.color.b, 1f);
    }
    public void changelevelfiftyNinetx()
    {
        levelfiftyninebtn.image.sprite = levelfifitynine;
        levelfiftyninebtn.image.color = new Color(levelfiftyninebtn.image.color.r, levelfiftyninebtn.image.color.g, levelfiftyninebtn.image.color.b, 1f);
    }
    public void changelevelsixtytx()
    {
        levelsixtybtn.image.sprite = levelsixty;
        levelsixtybtn.image.color = new Color(levelsixtybtn.image.color.r, levelsixtybtn.image.color.g, levelsixtybtn.image.color.b, 1f);
    }






    public void Loadlevelfirst(){
		LoadingPanel.SetActive (true);
		Application.LoadLevel("Level01");
	}
	public void loadleveltwo()
	{
		if (leveltwobtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log ("First clear the level you moron");

		} else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level02");
		}
	}
	public void Loadlevelthree()
	{

		if (levelthreebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level03");
		}

	}
	public void Loadlevelfour()
	{

		if (levelfourbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level04");
		}
	}
	public void Loadlevelfive()
	{

		if (levelfivebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level05");
		}
	}
	public void Loadlevelsix()
	{

		if (levelsixbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level06");
		}
	}
	public void Loadlevelseven()
	{

		if (levelsevenbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level07");
		}
	}
	public void Loadleveleight()
	{

		if (leveleightbtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level08");
		}
	}
	public void Loadlevelnine()
	{

		if (levelninebtn.GetComponent<Image> ().sprite.name == "Levels_03") {
			Debug.Log("First clear the level you moron");

		}
		else {
			LoadingPanel.SetActive (true);
			Application.LoadLevel("Level09");
		}
	}
    public void Loadlevelten()
    {

        if (leveltenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
           // lockAnim[8].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level10");
        }
    }
    public void LoadlevelEleven()
    {

        if (levelelevenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
            //lockAnim[9].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            Debug.Log("Level11");
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level11");
        }
    }
    public void LoadlevelTwelve()
    {

        if (leveltwelvebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[10].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level12");
        }
    }
    public void LoadlevelThirteen()
    {

        if (levelthirteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
        //    lockAnim[11].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level13");
        }
    }
    public void LoadlevelFourteen()
    {

        if (levelfourteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
           // lockAnim[12].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level14");
        }
    }
    public void LoadlevelFifteen()
    {

        if (levelfifteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[13].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level15");
        }
    }
    public void LoadlevelSixteen()
    {

        if (levelsixteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[14].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level16");
        }
    }
    public void LoadlevelSeventeen()
    {

        if (levelseventeenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[15].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level17");
        }
    }
    public void LoadlevelEighteen()
    {

        if (leveleighteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[16].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level18");
        }
    }
    public void LoadlevelNinteen()
    {

        if (levelninteenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[17].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level19");
        }
    }
    public void LoadlevelTwenty()
    {

        if (leveltwentybtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level20");
        }
    }
    public void LoadlevelTwentyOne()
    {

        if (leveltwentyonebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level21");
        }
    }
    public void LoadlevelTwentytwo()
    {

        if (leveltwentytwobtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level22");
        }
    }
    public void LoadlevelTwentythree()
    {

        if (leveltwentythreebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level23");
        }
    }
    public void LoadlevelTwentyfour()
    {

        if (leveltwentyfourbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level24");
        }
    }
    public void LoadlevelTwentyfive()
    {

        if (leveltwentyfivebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level25");
        }
    }
    public void LoadlevelTwentysix()
    {

        if (leveltwentysixbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level26");
        }
    }
    public void LoadlevelTwentyseven()
    {

        if (leveltwentysevenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level27");
        }
    }
    public void LoadlevelTwentyeight()
    {

        if (leveltwentyeightbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level28");
        }
    }
    public void LoadlevelTwentynine()
    {

        if (leveltwentyninebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level29");
        }
    }
    public void Loadlevelthirty()
    {

        if (levelthirtybtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level30");
        }
    }
    public void LoadlevelthirtyOne()
    {

        if (levelthirtyonebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level31");
        }
    }
    public void Loadlevelthirtytwo()
    {

        if (levelthirtytwobtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level32");
        }
    }
    public void Loadlevelthirtythree()
    {

        if (levelthirtythreebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level33");
        }
    }
    public void Loadlevelthirtyfour()
    {

        if (levelthirtyfourbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level34");
        }
    }
    public void Loadlevelthirtyfive()
    {

        if (levelthirtyfivebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level35");
        }
    }
    public void Loadlevelthirtysix()
    {

        if (levelthirtysixbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level36");
        }
    }
    public void Loadlevelthirtyseven()
    {

        if (levelthirtysevenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level37");
        }
    }
    public void Loadlevelthirtyeight()
    {

        if (levelthirtyeightbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level38");
        }
    }
    public void Loadlevelthirtynine()
    {

        if (levelthirtyninebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level39");
        }
    }
    public void Loadlevelfourty()
    {

        if (levelfourtybtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level40");
        }
    }
    public void Loadlevelfourtyone()
    {

        if (levelfourtyonebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level41");
        }
    }
    public void Loadlevelfourtytwo()
    {

        if (levelfourtytwobtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level42");
        }
    }
    public void Loadlevelfourtythree()
    {

        if (levelfourtythreebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level43");
        }
    }
    public void Loadlevelfourtyfour()
    {

        if (levelfourtyfourbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level44");
        }
    }
    public void Loadlevelfourtyfive()
    {

        if (levelfourtyfivebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level45");
        }
    }
    public void Loadlevelfourtysix()
    {

        if (levelfourtysixbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level46");
        }
    }
    public void Loadlevelfourtyseven()
    {

        if (levelfourtysevenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level47");
        }
    }
    public void Loadlevelfourtyeight()
    {

        if (levelfourtyeightbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level48");
        }
    }
    public void Loadlevelfourtynine()
    {

        if (levelfourtyninebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level49");
        }
    }
    public void Loadlevelfifty()
    {

        if (levelfiftybtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level50");
        }
    }
    public void Loadlevelfiftyone()
    {

        if (levelfiftyonebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level51");
        }
    }
    public void Loadlevelfiftytwo()
    {

        if (levelfiftytwobtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level52");
        }
    }
    public void Loadlevelfiftythree()
    {

        if (levelfiftythreebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level53");
        }
    }
    public void Loadlevelfiftyfour()
    {

        if (levelfiftyfourbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level54");
        }
    }
    public void Loadlevelfiftyfive()
    {

        if (levelfiftyfivebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level55");
        }
    }
    public void Loadlevelfiftysix()
    {

        if (levelfiftysixbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
          //  lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level56");
        }
    }
    public void Loadlevelfiftyseven()
    {

        if (levelfiftysevenbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level57");
        }
    }
    public void Loadlevelfiftyeight()
    {

        if (levelfiftyeightbtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level58");
        }
    }
    public void Loadlevelfiftynine()
    {

        if (levelfiftyninebtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
        //    lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level59");
        }
    }
    public void Loadlevelsixty()
    {

        if (levelsixtybtn.GetComponent<Image>().sprite.name == "Levels_03")
        {
            Debug.Log("First clear the level you moron");
         //   lockAnim[18].SetBool("Rotate", true);
            Invoke("StopRotate", 0.5f);

        }
        else
        {
            LoadingPanel.SetActive(true);
            Application.LoadLevel("Level60");
        }
    }

    void checklevelfirst()
	{
		if (PlayerPrefs.GetInt ("Level01") == 1)
			changeleveltwotx ();
	}
	void checklevelsecond (){
		if (PlayerPrefs.GetInt ("Level02") == 1)
			changelevelthreetx ();
	}
	void checklevelthird (){

		if (PlayerPrefs.GetInt ("Level03") == 1)
			changelevelfourtx ();
	}
	void checklevelfourth(){

		if (PlayerPrefs.GetInt ("Level04") == 1)
			changelevelfivetx ();
	}
	void checklevelfive(){

		if (PlayerPrefs.GetInt ("Level05") == 1)
			changelevelsixtx ();
	}
	void checklevelsix(){

		if (PlayerPrefs.GetInt ("Level06") == 1)
			changelevelseventx();
	}
	void checklevelseven(){

		if (PlayerPrefs.GetInt ("Level07") == 1)
			changeleveleighttx ();
	}
	void checkleveleight(){

		if (PlayerPrefs.GetInt ("Level08") == 1)
			changelevelninetx ();
	}
	void checklevelnine(){

        if (PlayerPrefs.GetInt("Level09") == 1) { }
			//changeleveltentx ();
	}
    void checklevelten()
    {

        if (PlayerPrefs.GetInt("Level10") == 1)
            changeleveleleventx();
    }
    void checkleveleleven()
    {

        if (PlayerPrefs.GetInt("Level11") == 1)
            changeleveltwelvetentx();
    }
    void checkleveltwelve()
    {

        if (PlayerPrefs.GetInt("Level12") == 1)
            changelevelthirteententx();
    }
    void checklevelthirteen()
    {

        if (PlayerPrefs.GetInt("Level13") == 1)
            changelevelfourteentx();
    }
    void checklevelfourteen()
    {

        if (PlayerPrefs.GetInt("Level14") == 1)
            changelevelfifiteentx();
    }
    void checklevelfifteen()
    {

        if (PlayerPrefs.GetInt("Level15") == 1)
            changelevelsixteentx();
    }
    void checklevelsexteen()
    {

        if (PlayerPrefs.GetInt("Level16") == 1)
            changelevelseventeentx();
    }
    void checklevelseventeen()
    {

        if (PlayerPrefs.GetInt("Level17") == 1)
            changeleveleighteentx();
    }

    void checkleveleighteen()
    {

        if (PlayerPrefs.GetInt("Level18") == 1)
            changelevelninteentx();
    }

    void checklevelnineteen()
    {

        if (PlayerPrefs.GetInt("Level19") == 1)
            changeleveltwentytx();
    }
    void checkleveltwenty()
    {

        if (PlayerPrefs.GetInt("Level20") == 1)
            changeleveltwentyonetx();
    }
    void checkleveltwentyone()
    {

        if (PlayerPrefs.GetInt("Level21") == 1)
            changeleveltwentytwotx();
    }
    void checkleveltwentytwo()
    {

        if (PlayerPrefs.GetInt("Level22") == 1)
            changeleveltwenthreetx();
    }
    void checkleveltwentythree()
    {

        if (PlayerPrefs.GetInt("Level23") == 1)
            changeleveltwentyfourtx();
    }
    void checkleveltwentyfour()
    {

        if (PlayerPrefs.GetInt("Level24") == 1)
            changeleveltwentyfivetx();
    }
    void checkleveltwentyfive()
    {

        if (PlayerPrefs.GetInt("Level25") == 1)
            changeleveltwentysixtx();
    }
    void checkleveltwentysix()
    {

        if (PlayerPrefs.GetInt("Level26") == 1)
            changeleveltwentyseventx();
    }
    void checkleveltwentyseven()
    {

        if (PlayerPrefs.GetInt("Level27") == 1)
            changeleveltweneighttx();
    }
    void checkleveltwentyeight()
    {

        if (PlayerPrefs.GetInt("Level28") == 1)
            changeleveltwentyninetx();
    }
    void checkleveltwentynine()
    {

        if (PlayerPrefs.GetInt("Level29") == 1)
            changelevelthirtytx();
    }
    void checklevelthirty()
    {

        if (PlayerPrefs.GetInt("Level30") == 1)
            changelevelthirtyonetx();
    }
    void checklevelthirtyOne()
    {

        if (PlayerPrefs.GetInt("Level31") == 1)
            changelevelthirtytwotx();
    }
    void checklevelthirtytwo()
    {

        if (PlayerPrefs.GetInt("Level32") == 1)
            changelevelthirtythreetx();
    }
    void checklevelthirtythree()
    {

        if (PlayerPrefs.GetInt("Level33") == 1)
            changelevelthirtyfourtx();
    }
    void checklevelthirtyfour()
    {

        if (PlayerPrefs.GetInt("Level34") == 1)
            changelevelthirtyfivetx();
    }
    void checklevelthirtyfive()
    {

        if (PlayerPrefs.GetInt("Level35") == 1)
            changelevelthirtysixtx();
    }
    void checklevelthirtysix()
    {

        if (PlayerPrefs.GetInt("Level36") == 1)
            changelevelthirtyseventx();
    }
    void checklevelthirtyseven()
    {

        if (PlayerPrefs.GetInt("Level37") == 1)
            changelevelthirtyeighttx();
    }
    void checklevelthirtyeight()
    {

        if (PlayerPrefs.GetInt("Level38") == 1)
            changelevelthirtyninetx();
    }
    void checklevelthirtynine()
    {

        if (PlayerPrefs.GetInt("Level39") == 1)
            changelevelfourtytx();
    }
    void checklevelfourty()
    {

        if (PlayerPrefs.GetInt("Level40") == 1)
            changelevelfourtyonetx();
    }
    void checklevelfourtyone()
    {

        if (PlayerPrefs.GetInt("Level41") == 1)
            changelevelfourtytwotx();
    }
    void checklevelfourtytwo()
    {

        if (PlayerPrefs.GetInt("Level42") == 1)
            changelevelfourtythreetx();
    }
    void checklevelfourtythree()
    {

        if (PlayerPrefs.GetInt("Level43") == 1)
            changelevelfourtyfourtx();
    }
    void checklevelfourtytfour()
    {

        if (PlayerPrefs.GetInt("Level44") == 1)
            changelevelfourtyfivetx();
    }
    void checklevelfourtytfive()
    {

        if (PlayerPrefs.GetInt("Level45") == 1)
            changelevelfourtysixtx();
    }
    void checklevelfourtytsix()
    {

        if (PlayerPrefs.GetInt("Level46") == 1)
            changelevelfourtyseventx();
    }
    void checklevelfourtytseven()
    {

        if (PlayerPrefs.GetInt("Level47") == 1)
            changelevelfourtyeighttx();
    }
    void checklevelfourtyteight()
    {

        if (PlayerPrefs.GetInt("Level48") == 1)
            changelevelfourtyninetx();
    }
    void checklevelfourtytnine()
    {

        if (PlayerPrefs.GetInt("Level49") == 1)
            changelevelfiftytx();
    }
    void checklevelfifty()
    {

        if (PlayerPrefs.GetInt("Level50") == 1)
            changelevelfiftyOnetx();
    }
    void checklevelfiftyone()
    {

        if (PlayerPrefs.GetInt("Level51") == 1)
            changelevelfiftyTwotx();
    }
    void checklevelfiftytwo()
    {

        if (PlayerPrefs.GetInt("Level52") == 1)
            changelevelfiftyThreetx();
    }
    void checklevelfiftythree()
    {

        if (PlayerPrefs.GetInt("Level53") == 1)
            changelevelfiftyFourtx();
    }
    void checklevelfiftyfour()
    {

        if (PlayerPrefs.GetInt("Level54") == 1)
            changelevelfiftyFivetx();
    }
    void checklevelfiftyfive()
    {

        if (PlayerPrefs.GetInt("Level55") == 1)
            changelevelfiftySixtx();
    }
    void checklevelfiftysix()
    {

        if (PlayerPrefs.GetInt("Level56") == 1)
            changelevelfiftySeventx();
    }
    void checklevelfiftyseven()
    {

        if (PlayerPrefs.GetInt("Level57") == 1)
            changelevelfiftyEighttx();
    }
    void checklevelfiftyeight()
    {

        if (PlayerPrefs.GetInt("Level58") == 1)
            changelevelfiftyNinetx();
    }
    void checklevelfiftynine()
    {

        if (PlayerPrefs.GetInt("Level59") == 1)
            changelevelsixtytx();
    }
    void checklevelsixty()
    {

        //if (PlayerPrefs.GetInt("Level60") == 1)
        //    changelevelsixtyOnetx();
    }
    public void Back(){
		Application.LoadLevel("MainMenu");
	}

}
