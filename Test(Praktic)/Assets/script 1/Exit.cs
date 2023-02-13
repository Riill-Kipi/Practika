using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public void PlaySceneii ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Exits()
    {
        Application.Quit();
    }

    public void Prodol(){
         SceneManager.LoadScene(0);
         Time.timeScale = 1;
    }

}
