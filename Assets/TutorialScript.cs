using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TutorialScript : MonoBehaviour
{
    [SerializeField]
    GameObject TutorialObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggeTutorial()
    {
        TutorialObject.SetActive(!TutorialObject.activeSelf);
    }
}
