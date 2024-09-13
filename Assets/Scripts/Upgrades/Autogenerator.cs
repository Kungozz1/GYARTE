using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Autogenerator : MonoBehaviour
{
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
    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
    }

    // Update is called once per frame
    void Update()
    {
        level.text = upgradelvl.ToString();
        lvlupcost.text = upgradecost.ToString();

    }

    public void onbuttonpress()
    {
        if (mscript.current_money > upgradecost)
        {
            upgradelvl++;
        }
    }
}
