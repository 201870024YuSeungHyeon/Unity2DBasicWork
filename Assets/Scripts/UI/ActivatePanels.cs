using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ActivatePanels : MonoBehaviour
{
    public GameObject ChangeCharPanel;
    public GameObject ChangeNamePanel;
    public GameObject CharListPanel;


    public Button ChangeCharButton; 
    public Button ChangeNameButton;
    public Button CharListButton;

    private PlayerInput playerInput;

    private void Awake()
    {
        
    }

    void Start()
    {
        // 버튼에 대한 클릭 이벤트를 설정합니다.
        ChangeCharButton.onClick.AddListener(ActiveChangeCharPanel);
        ChangeNameButton.onClick.AddListener(ActiveChangeNamePanel);
        CharListButton.onClick.AddListener(ActiveCharListPanel);
    }

    private void Update()
    {
        playerInput = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInput>();
    }

    public void ActiveChangeCharPanel()
    {
        ChangeCharPanel.SetActive(true);
        playerInput.enabled = false;
    }

    public void ActiveChangeNamePanel()
    {
        ChangeNamePanel.SetActive(true);
        playerInput.enabled = false;
    }

    public void ActiveCharListPanel()
    {
        CharListPanel.SetActive(true);
    }
    
    public void DeactivateChangeCharPanel()
    {
        ChangeCharPanel.SetActive(false);
        playerInput.enabled = true;
    }

    public void DeactivateChangeNamePanel()
    {
        ChangeNamePanel.SetActive(false );
        playerInput.enabled = true;
    }
    
    public void DeactiveCharListPanel()
    {
        CharListPanel.SetActive(false);
    }
}
