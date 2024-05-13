using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Button dialogueButton;
    public Button nextButton;
    public Text dialogueText;
    public string[] dialogue;
    private int index;

    public float wordSpeed;
    public bool playerIsClosed;

    private void Update()
    {
        if (dialogueText.text == dialogue[index])
        {
            nextButton.gameObject.SetActive(true);
        }
    }

    public void EnterDialogue()
    {
        if (playerIsClosed)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                ResetText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }

       
    }

    public void ResetText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach(char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);
        }
    }

    public void NextLine()
    {
        nextButton.gameObject.SetActive(false);

        if(index < dialogue.Length -1) 
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            ResetText() ;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            playerIsClosed = true;
            dialogueButton.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            playerIsClosed= false;
            dialogueButton.gameObject.SetActive(false);
            ResetText();
        }
    }
}
