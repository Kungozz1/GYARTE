using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Moneyscript : MonoBehaviour
{
    float money;
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
        coins.text = money.ToString();
    }
    public void onbuttonpress()
    {
        money += 1 * coinmultiplier;
    }
}
