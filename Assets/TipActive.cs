using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipActive : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("OK",0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OK() {
        Time.timeScale = 0f;
    }

}
