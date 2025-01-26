using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{

    [SerializeField]
    GameObject Maingamepanel;
    turnoffupgrade turnoffscript;
    [SerializeField]
    TMP_Text Score;
    [SerializeField]
    GameObject manager;
    [SerializeField]
    GameObject EndScreen;
    Moneyscript mscript;
    float minutes;
    float seconds;
    [SerializeField]
    TMP_Text TimerText;
    [SerializeField]
    float Timer;
    
    // Start is called before the first frame update
    void Start()
    {
        mscript = manager.GetComponent<Moneyscript>();
    }

    // Update is called once per frame
    void Update()
    {
        //divide the time by 60
        float minutes = Mathf.FloorToInt(Timer / 60);

        // returns the remainder
        float seconds = Mathf.FloorToInt(Timer % 60);
        Timer -= Time.deltaTime;
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        Score.text = mscript.TotalMoneyEarned.ToString();
        if (Timer <=0)
        {
            Timer = 1000000000;
            EndGame();
            
        }

    }
        void EndGame()
    {
        mscript.TotalMoneyEarned = mscript.TotalMoneyEarned += mscript.current_money;
        EndScreen.SetActive(true); 
        Maingamepanel.SetActive(false);
        StartCoroutine("yes");

        
    }
   public IEnumerator yes()
    {
        yield return new WaitForSeconds(0.1f);
        manager.SetActive(false);
    }

}
