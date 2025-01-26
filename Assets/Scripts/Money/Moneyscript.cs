using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;
using System.Globalization;

public class Moneyscript : MonoBehaviour
{
    public float TotalMoneyEarned;
    public float moneyperclick = 1;
    public float current_money ;
    [SerializeField]
    TMP_Text coins;
    [SerializeField]
    TMP_Text gambling_coins;
    [SerializeField]
   public float coinmultiplier;
    [SerializeField]
    public float coinclickmultiplier;
    Autogenerator autogen;
    Upgradescript upgradescript;
    [SerializeField] 
    public float Coinaudio;


    // Start is called before the first frame update
    void Start()
    {
     
        upgradescript = GetComponent<Upgradescript>();
        coinclickmultiplier = 1;
        coinmultiplier = 1;
        moneyperclick = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (current_money <1000)
        {
            coins.text = ("0000"+current_money.ToString());

        }
        if (current_money >=1000 && current_money< 1000000)
        {
            coins.text = (current_money/1000).ToString("#.0K", CultureInfo.InvariantCulture);
        }
        else 
        {
            if (current_money >= 1000000 && current_money < 1000000000)
            {
                coins.text = (current_money/1000000).ToString("#.0M", CultureInfo.InvariantCulture);
            }
            else
            {
                if (current_money >= 1000000000)
                {
                    coins.text = (current_money/1000000000).ToString("#.0B", CultureInfo.InvariantCulture);
                   
                }
                else
                {
                    coins.text = current_money.ToString();
                }
            }
           
        }
        if (current_money >= 1000 && current_money < 1000000)
        {
            gambling_coins.text = (current_money / 1000).ToString("#.0K", CultureInfo.InvariantCulture);
        }
        else
        {
            if (current_money >= 1000000 && current_money < 1000000000)
            {
                gambling_coins.text = (current_money / 1000000).ToString("#.0M", CultureInfo.InvariantCulture);
            }
            else
            {
                if (current_money >= 1000000000)
                {
                    gambling_coins.text = (current_money / 1000000000).ToString("#.0B", CultureInfo.InvariantCulture);

                }
                else
                {
                    gambling_coins.text = current_money.ToString();
                }
            }

        }


    }
    public void onbuttonpress()
    {
        current_money += moneyperclick * coinclickmultiplier;
        Coinaudio += moneyperclick* coinclickmultiplier;
    }


    



}
