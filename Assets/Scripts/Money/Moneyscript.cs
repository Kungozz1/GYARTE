using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

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

    // Start is called before the first frame update
    void Start()
    {
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
