using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{



    


// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

}
    public void Play() //när den här voiden händer, t.ex. när man trycker på en knapp, så loadar den scenen som heter mainScene
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Quit() //spelet stängs ner
    {
        Application.Quit();
        Debug.Log("Player quit"); //says if the void works since we can't see if it works otherwise if we are not in a build
    }








}


