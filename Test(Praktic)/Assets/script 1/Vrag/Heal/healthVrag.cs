using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthVrag : MonoBehaviour
{
    public int healvrag;
    public int nit = 1;
    public static int healthBoss;
    void Start()
    {
        DamtdgVrag(0);
    }

    public void DamtdgVrag(int damage)
    {
        healvrag -= damage;
        if (gameObject.tag == "Boss")
        {
            healthBoss = healvrag;
        }

        if (healvrag <= 0){
            
            if (gameObject.tag == "Vrag") 
            { 
                GetComponent<EnewyFollow>().SpawnHil();
                Destroy(gameObject);
            }
        }
        if(healthBoss <= 0){

            if (gameObject.tag == "Boss")
            {
                //VinMenu.SetActive(true);
                Destroy(gameObject);
                Time.timeScale = 0;
            }
        }
    }
}
