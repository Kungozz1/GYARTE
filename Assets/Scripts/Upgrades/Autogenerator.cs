using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Autogenerator : MonoBehaviour
{
    [SerializeField]
    public float moneytimer;
    [SerializeField]
    string Name;
    [SerializeField]
    Button button;
    [SerializeField]
    TMP_Text level;
    [SerializeField]
    TMP_Text lvlupcost;
    [SerializeField]
    float upgradecost;
    [SerializeField]
    float upgradelvl;
    [SerializeField]
    public float CPS;
    [SerializeField]
    GameObject manager;
    Moneyscript mscript;
    [SerializeField]
    float CPSInc;
    [SerializeField]
    float upgradeinc;


    public int roundupcost;
    public int roundupcps;
    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
    }

    // Update is called once per frame
    void Update()
    {
        roundupcost = (int)(upgradecost + 0.5f);
        roundupcps = (int)(CPS + 0.5f);
        moneytimer += Time.deltaTime;
        level.text = upgradelvl.ToString();
        lvlupcost.text = roundupcost.ToString();
        CPS = CPSInc * upgradelvl;

        autoMoney();

        if (upgradelvl >= 50)
        {
            level.text = "max";
            button.interactable = false;
        }
    }

    public void genonbuttonpress()
    {
        if (mscript.current_money >= upgradecost)
        {
            upgradelvl++;
            mscript.current_money -= roundupcost;
            upgradecost *= upgradeinc;
            
        }
    }


    public void autoMoney()
    {
        if (moneytimer >= 0.1)
        {
            mscript.current_money += roundupcps / 10;
            moneytimer = 0;
        }

    }
}
