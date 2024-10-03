using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class turnoffupgrade : MonoBehaviour
{
    [SerializeField]
    GameObject gamblingpanel;
    [SerializeField]
    GameObject sidepanel;
    [SerializeField]
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onbuttonpress()
    {
        sidepanel.SetActive(!sidepanel.activeSelf);
        gamblingpanel.SetActive(!gamblingpanel.activeSelf);


    }
}
