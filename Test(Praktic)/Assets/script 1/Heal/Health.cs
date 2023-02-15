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
            GetComponent<slider>().UpdatehealSlider();
            healthPlay = health;
        }
        //Если здоровье меньше 0 - уничтожить объект на котором весит этот скрипт
        if (health <= 0)
        {
            // if (hil[0] != null) { 
            //    Debug.Log("HilSpawn");
            if (gameObject.tag == "Player")
            {
                GetComponent<slider>().UpdatehealSlider();
                anim.SetBool("smert", true);
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
        GetComponent<slider>().UpdatehealSlider();
    }

    public void Destroe()
    {
        Destroy(gameObject);
        Time.timeScale = 0;
        /////
    }

    public void FFF()
    {
        anim.SetBool("uron", false);
    }
}