using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    // Array of character skins
    public Sprite[] characterSkins;

    void Start()
    {
        // Retrieve the selected skin index from the CharacterSelection script
        int selectedSkinIndex = CharacterSelection.currentSkinIndex;

        // Set the character's skin to the selected skin
        SetCharacterSkin(characterSkins[selectedSkinIndex]);
    }

    public void SetCharacterSkin(Sprite skin)
    {
        // Set the character's skin to the specified skin
        SpriteRenderer renderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component of the character
        renderer.sprite = skin; // Set the sprite of the SpriteRenderer component to the specified skin
    }
}