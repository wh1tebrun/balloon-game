using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

[System.Serializable]

public class GameData
{
    public float money;
    public float owned;
}







public class ShopScript : MonoBehaviour
{
    public Image sr;
    public List<Sprite> skins = new List<Sprite>();
    private int selectedSkin = 0;
    public GameObject playerskin;
    public Image SelectedCharacter;
    public Sprite defaultCharacter;
    public Sprite Character1;
    public Sprite Character2;
    public Sprite Character3;
    public Sprite Character4;
    public Sprite Character5;
    public Sprite Item1;
    public Sprite Item2;
    public Sprite Item3;
    public Sprite Item4;
    public Sprite Item5;
    public float priceOfCharacter1;
    public float priceOfCharacter2;
    public float priceOfCharacter3;
    public float priceOfCharacter4;
    public float priceOfCharacter5;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public GameObject Button4;
    public GameObject Button5;
   
    [SerializeField]TMP_Text moneyText;



    public void NextOption()
    {
        selectedSkin = selectedSkin + 1;
        if(selectedSkin == skins.Count)
        {
            selectedSkin = 0;
        }
        sr.sprite = skins[selectedSkin];
    }
     public void BackOption()
    {
        selectedSkin = selectedSkin - 1;
        if(selectedSkin < 0)
        {
            selectedSkin = skins.Count -1;
        }
        sr.sprite = skins[selectedSkin];
    }

    public void PlayGame()
    {
        PrefabUtility.SaveAsPrefabAsset(playerskin, "Assets/Sprites/Balloon2.prefab");
        SceneManager.LoadScene("Game");
    }



    public GameData gameData = new GameData();
    void Start()
    {
       gameData = BinarySerializer.Load<GameData>("gamedata");

        if(gameData.owned == 1)
        {
            Button1.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = gameData.money.ToString();
    }


    public void buyCharacter1()
    {
        gameData.money -= priceOfCharacter1;

        gameData.owned = 1;
        Button1.SetActive(false);

    }
    public void buyCharacter2()
    {
        gameData.money -= priceOfCharacter2;

        gameData.owned = 1;
        Button1.SetActive(false);

    }
    public void buyCharacter3()
    {
        gameData.money -= priceOfCharacter3;

        gameData.owned = 1;
        Button1.SetActive(false);

    }
    public void buyCharacter4()
    {
        gameData.money -= priceOfCharacter4;

        gameData.owned = 1;
        Button1.SetActive(false);

    }
    public void buyCharacter5()
    {
        gameData.money -= priceOfCharacter5;

        gameData.owned = 1;
        Button1.SetActive(false);

    }
    public void SelectCharacter()
    {
        SelectedCharacter.GetComponent<Image>().sprite = defaultCharacter;

    }

    public void SelectCharacter1()
    {
        SelectedCharacter.GetComponent<Image>().sprite = Character1;
    
    }

    

    private void OnApplicationQuit()
    {
        BinarySerializer.Save<GameData>(gameData, "gamedata");
    }
}
