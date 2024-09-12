using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Moneyscript : MonoBehaviour
{
    float current_money;
    [SerializeField]
    TMP_Text coins;
    [SerializeField]
    float coinmultiplier;

    // Start is called before the first frame update
    void Start()
    {
        coinmultiplier = 1;
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = current_money.ToString();
    }
    public void onbuttonpress()
    {
        current_money += 1 * coinmultiplier;
    }
}
