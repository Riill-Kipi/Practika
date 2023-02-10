using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Значение здоровья
    public int health;
    public static int healthPlay = 100;
    public static int healthBoss;
    //Максимальное значение здоровья
    public int maxHealth;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        TakeHit(0);
    }
    //Функция получения урона
    public void TakeHit(int damage)
    {
        health -= damage;

        if (gameObject.tag == "Player")
        {
            healthPlay = health;
        }

        if (gameObject.tag == "Boss")
        {
            healthBoss = health;
        }

        //Если здоровье меньше 0 - уничтожить объект на котором весит этот скрипт
        if (health <= 0)
        {
            // if (hil[0] != null) { 
            //    Debug.Log("HilSpawn");
            if (gameObject.tag == "Player")
            {
                anim.SetBool("smert", true);
            }

            if (gameObject.tag == "Vrag") 
            { 
                GetComponent<EnewyFollow>().SpawnHil();
                Destroy(gameObject);
            }
        }
            
    }

    //Функция прибавления здоровья
    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
        {
            health = maxHealth;
        }

        if (gameObject.tag == "Player")
        {
            healthPlay = health;
        }

    }

    public void Destroe()
    {
        Destroy(gameObject);
    }

    public void FFF()
    {
        anim.SetBool("uron", false);
    }
}