using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class SkinManager : MonoBehaviour
{
   [SerializeField] private TMP_Text skinNameText;
   [SerializeField] private SpriteRenderer skinSprite;

   public SkinDatabase skinDatabase;
   private int selectedSkin = 0;


   private void Start()
   {
    if(PlayerPrefs.HasKey("selectedSkin"))
    {
        Load();
    }
    else
    {
        selectedSkin = 0;
    }


    UpdateSkin(selectedSkin);
   }

   public void NextButton()
   {
    selectedSkin++;

    if(selectedSkin >= skinDatabase.SkinCounter)
    {
        selectedSkin = 0;

    }
    UpdateSkin(selectedSkin);
    Save();




   }

   public void BackButton()
   {
    selectedSkin--;

    if(selectedSkin < 0)
    {
        selectedSkin = skinDatabase.SkinCounter - 1;

    }
    UpdateSkin(selectedSkin);
    Save();



    
   }




   private void UpdateSkin(int selected)
   {
    SkinBase skinBase = skinDatabase.GetSkin(selected);
    skinSprite.sprite = skinBase.skinSprite;
    skinNameText.text = skinBase.skinName;

   }

   private void Load()
   {
    selectedSkin = PlayerPrefs.GetInt("selectedSkin");

   }

   private void Save()
   {
    PlayerPrefs.SetInt("selectedSkin", selectedSkin);
   }


   public void LoadGameScene()
   {
    SceneManager.LoadScene("Game");
   }
}
