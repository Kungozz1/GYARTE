using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.Linq;

public class GamblingScript : MonoBehaviour
{
    [SerializeField]
    GameObject gamblingcanvas;
    
    
    [SerializeField]
    float gambling_timer;
    [SerializeField]
    TMP_Text gambling_button;
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
    [Range(1,16)]
    int Lucky_number;
    Moneyscript mscript;
    [SerializeField]
    public int num1;
    [SerializeField]
   public  int num2;
    [SerializeField]
    float winnings;

    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {


        
        

        gambling_timer += Time.deltaTime;
        gambling_button.text = "Gamble "+gambling_price.ToString()+" Gold";

    }
    public void gambling()
    {
        if (mscript.current_money >= gambling_price)
        {
            mscript.current_money -= gambling_price;

            rng = UnityEngine.Random.Range(num1, num2);
            print(rng);


            if (rng == Lucky_number)
            {
                print("yayyy you won " + winnings + " Gold");
                mscript.current_money += winnings;
            }
        }
        
        


    }
    

}
