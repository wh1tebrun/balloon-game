using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour
{

    [SerializeField] Slider Slider;
    
    void Start()
    {
        if(!PlayerPrefs.HasKey("SFXVolume"))
        {
            PlayerPrefs.SetFloat("SFXVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
        
    }
    public void ChangeVolume()
    {
        AudioListener.volume = Slider.value;
        Save();
    }

    private void Load()
    {
        Slider.value = PlayerPrefs.GetFloat("SFXVolume");

    }

    private void Save()
    {
        PlayerPrefs.SetFloat("SFXVolume", Slider.value);
    }

}
