using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class GamblingScript : MonoBehaviour
{
    [SerializeField]
    GameObject manager;
    [SerializeField]
    GameObject Gamblingmanager;
    [SerializeField]
   public float gambling_price;
    float rng;
    [SerializeField]
    Button button;
    [SerializeField]
    float odds;
    Moneyscript mscript;

    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gambling()
    {
        if (mscript.current_money >= gambling_price)
        {
            mscript.current_money -= gambling_price;
        }
        
        rng = UnityEngine.Random.Range(1,1001);
        print(rng);


        if (rng == odds)
        {
            print("yayyy");
            mscript.current_money += 1000;
        }


    }
}
