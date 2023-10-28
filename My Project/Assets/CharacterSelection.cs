using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CharacterSelection : MonoBehaviour
{
    // Array of character skins
    public Sprite[] characterSkins;
    public Image[] characterImages;

    // Text component to display the name of the currently selected skin
    public TMP_Text skinNameText;

    // Button game objects for the Previous, Next, Select, and Play buttons
    public GameObject previousButton;
    public GameObject nextButton;
    public GameObject selectButton;
    public GameObject playButton;
    public GameObject PanelGame;

    // Index of the currently selected skin in the characterSkins array
    public static int currentSkinIndex = 0;

    void Start()
    {
        // Set the text of the skinNameText component to the name of the currently selected skin
        skinNameText.text = characterSkins[currentSkinIndex].name;

        // Add a listener to the "Previous" button's onClick event, calling the OnPreviousButtonClicked function when the button is clicked
        previousButton.GetComponent<Button>().onClick.AddListener(OnPreviousButtonClicked);
        // Add a listener to the "Next" button's onClick event, calling the OnNextButtonClicked function when the button is clicked
        nextButton.GetComponent<Button>().onClick.AddListener(OnNextButtonClicked);
        // Add a listener to the "Select" button's onClick event, calling the OnSelectButtonClicked function when the button is clicked
        selectButton.GetComponent<Button>().onClick.AddListener(OnSelectButtonClicked);
        // Add a listener to the "Play" button's onClick event, calling the OnPlayButtonClicked function when the button is clicked
        playButton.GetComponent<Button>().onClick.AddListener(OnPlayButtonClicked);
    }

    public void OnPreviousButtonClicked()
    {
        // Decrement the current skin index
        currentSkinIndex--;
        // If the index is less than 0, set it to the last skin in the list
        if (currentSkinIndex < 0)
        {
        currentSkinIndex = characterSkins.Length - 1;
        }
        // Update the skinNameText component to display the name of the new selected skin
        skinNameText.text = characterSkins[currentSkinIndex].name;

        // Save the current skin index to PlayerPrefs
        PlayerPrefs.SetInt("SelectedCharacterSkin", currentSkinIndex);
        }

        public void OnNextButtonClicked()
        {
        // Increment the current skin index
        currentSkinIndex++;
        // If the index is greater than or equal to the number of skins in the list, set it to the first skin in the list
        if (currentSkinIndex >= characterSkins.Length)
        {
        currentSkinIndex = 0;
        }
        // Update the skinNameText component to display the name of the new selected skin
        skinNameText.text = characterSkins[currentSkinIndex].name;

        // Save the current skin index to PlayerPrefs
        PlayerPrefs.SetInt("SelectedCharacterSkin", currentSkinIndex);
        }

        public void OnSelectButtonClicked()
        {
        // Set the character's skin to the currently selected skin
        SetCharacterSkin(characterSkins[currentSkinIndex]);

        // Save the current skin index to PlayerPrefs
        PlayerPrefs.SetInt("SelectedCharacterSkin", currentSkinIndex);
        }

        public void OnPlayButtonClicked()
        {
        // Load the game scene
        PanelGame.SetActive(false);
        }

        public void SetCharacterSkin(Sprite skin)
        {
        // Set the character's skin to the specified skin
        GameObject character = GameObject.Find("Balloon"); // Find the character GameObject
        SpriteRenderer renderer = character.GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component of the character
        renderer.sprite = skin; // Set the sprite of the SpriteRenderer component to the specified skin
        
        }
        }