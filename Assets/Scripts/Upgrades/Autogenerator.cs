using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Autogenerator : MonoBehaviour
{
    [SerializeField]
    float moneytimer;
    [SerializeField]
    string name;
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
    float CPS;
    [SerializeField]
    GameObject manager;
    Moneyscript mscript;


    int roundupcost;
    int roundupcps;
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
        CPS = 15 * upgradelvl;
        autoMoney();

        if (upgradelvl >= 50)
        {
            level.text = "max";
            button.interactable = false;
        }
    }

    public void onbuttonpress()
    {
        if (mscript.current_money >= upgradecost)
        {
            upgradelvl++;
            mscript.current_money -= roundupcost;
            upgradecost *= 1.3f;
            
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
