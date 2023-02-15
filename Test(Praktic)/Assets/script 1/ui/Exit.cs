using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject GameMenu;
    int nit= 2; 
    public GameObject VinMenu;
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

    public void gameMenuPlaer(int menuchislo)
    {
        nit -= menuchislo;
        if(menuchislo == 1){
            GameMenu.SetActive(true);
        }else if(menuchislo == 0){
            VinMenu.SetActive(true);
        }
    }

    public void gameMenu(){
        GameMenu.SetActive(true);
    }

}
