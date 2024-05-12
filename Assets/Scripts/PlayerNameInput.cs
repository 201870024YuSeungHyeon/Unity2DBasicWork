using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerNameInput : MonoBehaviour
{
    [SerializeField] private InputField nameInputField;
    [SerializeField] private Button joinBtn;
    [SerializeField] private Text nameTag;
    

    private void Start()
    {
        joinBtn.interactable = false;
        nameInputField.onValueChanged.AddListener(delegate { ValidateInput(nameInputField.text); });
       
       
    }

   

    private void ValidateInput(string input)
    {
        if(input.Length >= 2 && input.Length <= 10)
        {
            joinBtn.interactable = true;
        }
        else
        {
            joinBtn.interactable= false;
        }
    }

    public void JoinGame()
    {
        PlayerPrefs.SetString("PlayerName",nameInputField.text);
        SceneManager.LoadScene("MainScene");
    }

   
}
