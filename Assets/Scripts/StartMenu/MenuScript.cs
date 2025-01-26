using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{



    



    public void Play() //n�r den h�r voiden h�nder, t.ex. n�r man trycker p� en knapp, s� loadar den scenen som heter mainScene
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit() //spelet st�ngs ner
    {
        Application.Quit();
        Debug.Log("Player quit"); //says if the void works since we can't see if it works otherwise if we are not in a build
    }


    public void MainMeny() 
    {
        SceneManager.LoadScene("Start scene");
    }





}


