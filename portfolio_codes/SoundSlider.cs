using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SoundSlider : MonoBehaviour
{

    Slider m_Slider;
    // [SerializeField]
    // bool m_isInput;
    // [SerializeField]
    // float m_ScroolSpeed = 1;
    void Awake()
    {
        m_Slider = GetComponent<Slider>();
        m_Slider.value = AudioListener.volume ;
    }

    private void OnEnable()
    {
        m_Slider.value = AudioListener.volume;
        m_Slider.onValueChanged.AddListener((sliderValue) => AudioListener.volume = sliderValue);
    }

    private void OnDisable()
    {
        m_Slider.onValueChanged.RemoveAllListeners();
    }

}
