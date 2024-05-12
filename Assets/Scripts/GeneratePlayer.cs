using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlayer : MonoBehaviour
{
    public CharacterDatabase characterDB;
    private int selectedOption = 0;
    public GameObject[] playerPrefabs;

    private void Start()
    {
        //characterDB = GetComponent<CharacterDatabase>();
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        GenerateCharacter(selectedOption);
    }


    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void GenerateCharacter(int selectedOption)
    {
        //Character character = characterDB.GetCharacter(selectedOption);
        Vector3 spawnPosition = new Vector3(0,0,0);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(playerPrefabs[selectedOption],spawnPosition,spawnRotation);
    }
}
