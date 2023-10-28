using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{

    [SerializeField] Slider Slider;
    
    void Start()
    {
        if(!PlayerPrefs.HasKey("MusicVolume"))
        {
            PlayerPrefs.SetFloat("MusicVolume", 1);
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
        Slider.value = PlayerPrefs.GetFloat("MusicVolume");

    }

    private void Save()
    {
        PlayerPrefs.SetFloat("MusicVolume", Slider.value);
    }

}
