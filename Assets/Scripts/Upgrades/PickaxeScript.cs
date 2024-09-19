using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Pickaxescript : MonoBehaviour
{
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

    int roundupcost;

    [SerializeField]
    GameObject manager;
    Moneyscript mscript;
    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
    }

    // Update is called once per frame
    void Update()
    {
        level.text = upgradelvl.ToString();
        lvlupcost.text = roundupcost.ToString();
        //mscript.coinclickmultiplier += 1;
        roundupcost = (int)(upgradecost + 0.5f);
        if (upgradelvl >= 50)
        {
            level.text = "max";
            button.interactable = false;
        }

    }

    public void onbuttonpress()
    {
        if (mscript.current_money >= roundupcost)
        {
            
            upgradelvl++;
            mscript.current_money -= roundupcost;
            upgradecost *= 1.1f;
            mscript.moneyperclick += 1;
        }
    }
    public void Givemoney()
    {
        mscript.current_money += mscript.moneyperclick;


    }


}
