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

    // Start is called before the first frame update
    void FixedUpdate()
    {
        if (gameObject.tag == "Player")
        {
            Heal();
        }else if (gameObject.tag == "Boss")
        {
            healBoss();
        }

    }
    void Heal()
    {
        text.text = $"HP  : {Health.healthPlay}%";
        if (Health.healthPlay == 0)
        {
            return;
        }
    }
    
    void healBoss()
    {
        hpboss.text = "HP :" + Health.healthBoss + "%";
        if (Health.healthBoss == 0)
        {
            return;
        }
    }
    
}
