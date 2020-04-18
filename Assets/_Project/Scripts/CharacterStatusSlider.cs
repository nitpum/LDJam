using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatusSlider : MonoBehaviour
{

    public Slider slider;

    public FloatVariable status;

    void Update()
    {
        slider.value = status.value / status.maxValue;
    }
}
