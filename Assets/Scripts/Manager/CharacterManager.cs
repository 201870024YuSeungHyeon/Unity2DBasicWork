using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public CharacterDatabase characterDB;
    public GameObject selectPanel;

    
    public Image artworkSprite;

    private int selectedOption = 0;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if(selectedOption >= characterDB.characterCount)
        {
            selectedOption = 0;
        }

        UpdateCharacter(selectedOption);
       
    }

    public void BackOption()
    {
        selectedOption--;

        if(selectedOption < 0)
        {
            selectedOption = characterDB.characterCount - 1;
        }
        UpdateCharacter(selectedOption);
       
    }

    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        
    }


    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("selectedOption",selectedOption);
        selectPanel.SetActive(false); ;
        
    }

}
