using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PickaxeScript : MonoBehaviour
{
    [SerializeField]
    GameObject button;
    [SerializeField]
    GameObject Manager;
    Moneyscript Mscript;
    [SerializeField]
    TMP_Text PickaxeLvl;
    [SerializeField]
    TMP_Text lvlcost;

    // Start is called before the first frame update
    void Start()
    {
        Mscript = Manager.GetComponent<Moneyscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onButtonpress()
    {

    }
}
