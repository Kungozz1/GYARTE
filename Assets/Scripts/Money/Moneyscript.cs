using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class Moneyscript : MonoBehaviour
{
    public float moneyperclick = 1;
    public float current_money;
    [SerializeField]
    TMP_Text coins;
    [SerializeField]
   public float coinmultiplier;
    [SerializeField]
    public float coinclickmultiplier;
    Autogenerator autogen;
    Upgradescript upgradescript;



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
        coins.text = current_money.ToString();
    }
    public void onbuttonpress()
    {
        current_money += moneyperclick * coinclickmultiplier;
    }


    
}
