using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayAudioScript : MonoBehaviour
{
    [SerializeField]
    GameObject manager;
    public AudioSource AudioSource;
    public AudioClip clip;
    Moneyscript moneyscript;
    private void Start()
    {
        moneyscript = manager.GetComponent<Moneyscript>();
    }
    // Update is called once per frame
    void Update()
    {
        
        if (moneyscript.current_money <= 10000)
        {
            if (moneyscript.Coinaudio >= 500)
           { 
                AudioSource.PlayOneShot(clip);
                moneyscript.Coinaudio = 0;
            }
        }
        else if(moneyscript.current_money <= 1000000)
        {
            if (moneyscript.Coinaudio >= 1000)
            {
                AudioSource.PlayOneShot(clip);
                moneyscript.Coinaudio = 0;
            }
        }
        if (moneyscript.current_money <= 100000)
        {
            if (moneyscript.Coinaudio >= 50000)
            {
                AudioSource.PlayOneShot(clip);
                moneyscript.Coinaudio = 0;
            }
        }
        else if (moneyscript.current_money <= 1000000000)
        {
            if (moneyscript.Coinaudio >= 5000000)
            {
                AudioSource.PlayOneShot(clip);
                moneyscript.Coinaudio = 0;
            }
        }
    }
}
