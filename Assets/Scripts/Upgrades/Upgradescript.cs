using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upgradescript : MonoBehaviour
{
    public int roundupcost;
    [SerializeField]
    TMP_Text superupgradelevel;
    [SerializeField]
    string upgradeName;
    [SerializeField]
    float upgradeincrease = 1.2f;
    Moneyscript mscript;
   public  float cpsboost = 1;
    [SerializeField]
    public float upgradecost;
    int upgradelevel = 0;
    [SerializeField]
    float inccps;
    // Start is called before the first frame update
    void Start()
    {
        cpsboost = 1;
        mscript = GetComponent<Moneyscript>();
        upgradelevel = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        roundupcost = (int)(upgradecost * upgradeincrease + 0.5f);
        
        cpsboost = Mathf.Pow(inccps, upgradelevel);
        


        superupgradelevel.text = upgradelevel.ToString();
    }

    public void boostonbuttonpress()
    {
        if (mscript.current_money >= roundupcost)
        {
            upgradelevel++;
            mscript.current_money -= roundupcost;
            upgradecost *= upgradeincrease;

        }
    }
}
