using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Shet : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI hpboss;
    //public bool thisIsBoss;
    // Start is called before the first frame update
    void FixedUpdate()
    {
           
        Heal();
        healBoss();
      

    }
   // OnCollison2DEnter(Collider2D other)
   // {
   //     if (gameObject.tag == "Player") 
   //     {
   //         Heal();
   //     }
   //     else if (gameObject.tag == "Boss")
   //     {
   //         healBoss();
   //     }
   // }
    void Heal()
    {
        text.text = $"HP  : {Health.healthPlay}%";
        if (Health.healthPlay <= 0)
        {
            text.enabled = false;
        }
    }
    
    void healBoss()
    {
        hpboss.enabled = true;
        hpboss.text = "HP :" + Health.healthBoss + "%";
        if (Health.healthBoss <= 0)
        {
            hpboss.enabled = false;
        }
    }
    
}
