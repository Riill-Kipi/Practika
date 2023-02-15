using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    [SerializeField] public Slider healSlider;

    // Update is called once per frame
    public  void UpdatehealSlider()
    {
        healSlider.maxValue = 100;
        healSlider.minValue = 0;
        healSlider.value = Health.healthPlay;

        if(Health.healthPlay <= 0){
            healSlider.enabled = false;
        }
    }
}
