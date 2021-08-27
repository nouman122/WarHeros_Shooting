using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabWeapon : MonoBehaviour {
    public AudioSource FireSfx;
	public Transform firePoint;
	public GameObject bulletPrefab;
    public bool shootRight = false;
    public bool shootLeft = false;
    public GameObject GunBlasteffect;
    public bool m_FacingRight = true;
    public GameObject[] Weapons;
    // Update is called once per frame
    void Update () {

        if (PlayerPrefs.GetInt("Default") == 1)
        {
            Debug.Log("Inside");
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(true);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
       else if (PlayerPrefs.GetInt("Char1") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(true);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char2") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(true);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char3") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(true);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char4") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(true);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char5") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(true);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char6") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(true);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char7") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(true);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char8") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(true);
            Weapons[10].SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Char9") == 1)
        {
            Weapons[0].SetActive(false);
            Weapons[1].SetActive(false);
            Weapons[2].SetActive(false);
            Weapons[3].SetActive(false);
            Weapons[4].SetActive(false);
            Weapons[5].SetActive(false);
            Weapons[6].SetActive(false);
            Weapons[7].SetActive(false);
            Weapons[8].SetActive(false);
            Weapons[9].SetActive(false);
            Weapons[10].SetActive(true);
        }



        if (shootRight )
		{
          
          //  Flip();
            Shoot();
            shootRight = false;
		}
       else if (shootLeft && m_FacingRight)
        {
           // Shoot();
           // Flip();
           // Shoot1();
            shootLeft = false;
        }
    }
    public void OnPress() {
   
        shootRight = true;
        GunBlasteffect.SetActive(true);
        Invoke("Off", 0.4f);
    }
   

    void Shoot ()
	{
       
        FireSfx.Play();
		Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
     
    }
    void Shoot1()
    {

        FireSfx.Play();
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
    public void Off() {
        GunBlasteffect.SetActive(false);
    }
  
}
