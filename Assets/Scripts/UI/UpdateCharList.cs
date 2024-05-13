using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UpdateCharList : MonoBehaviour
{
    public GameObject charListTextPrefab;
    public Transform charListContent;

   public void CharListBtnPressed()
    {
        UpdateCharacterList();
    }

    private void UpdateCharacterList()
    {
        foreach(Transform child in charListContent)
        {
            Destroy(child.gameObject);
        }

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] npcs = GameObject.FindGameObjectsWithTag("NPC");

        foreach(GameObject characters in players)
        {
            AddCharactersToList(GetNameFromCanvas(characters));
        }
        foreach(GameObject characters in npcs)
        {
            AddCharactersToList(GetNameFromCanvas(characters));
        }
    }

    private void AddCharactersToList(string name)
    {
        GameObject charText = Instantiate(charListTextPrefab,charListContent);
        charText.GetComponent<Text>().text = name;
    }

    private string GetNameFromCanvas(GameObject character)
    {
        string objectName = character.CompareTag("NPC") ? "CharName" : "PlayerName";

        Transform canvasTransform = character.transform.Find("Canvas");
        
        if (canvasTransform != null)
        {
            
            Transform nameTransform = canvasTransform.Find(objectName);
            if (nameTransform != null)
            {
                
                Text nameText = nameTransform.GetComponent<Text>();
                if (nameText != null)
                {
                    
                    return nameText.text;
                }
            }

           
        }
        return character.name;
    }
}
