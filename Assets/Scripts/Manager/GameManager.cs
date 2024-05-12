using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private string playerTag;
    public Transform Player { get; private set; }

    public CharacterDatabase characterDB;
    private int selectedOption = 0;
    public GameObject[] playerPrefabs;

    public Text timeTxt;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

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

        GenerateCharacter(selectedOption);
    }


    void Update()
    {
        DateTime currentTime = DateTime.Now;
        timeTxt.text = currentTime.ToString("HH:mm:ss");

       if(Player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if(playerObject != null )
            {
                Player = playerObject.transform;
            }
        }
    }

    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    private void GenerateCharacter(int selectedOption)
    {
        //Character character = characterDB.GetCharacter(selectedOption);
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(playerPrefabs[selectedOption], spawnPosition, spawnRotation);
    }

}
