using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ActivatePanels : MonoBehaviour
{
    public GameObject ChangeCharPanel;
    public GameObject ChangeNamePanel;


    public Button ChangeCharButton; 
    public Button ChangeNameButton; 

    void Start()
    {
        // ��ư�� ���� Ŭ�� �̺�Ʈ�� �����մϴ�.
        ChangeCharButton.onClick.AddListener(ActiveChangeCharPanel);
        ChangeNameButton.onClick.AddListener(ActiveChangeNamePanel);
    }

    public void ActiveChangeCharPanel()
    {
        ChangeCharPanel.SetActive(true);
    }

    public void ActiveChangeNamePanel()
    {
        ChangeNamePanel.SetActive(true);
    }
    public void DeactivateChangeCharPanel()
    {
        ChangeCharPanel.SetActive(false);
    }

    public void DeactivateChangeNamePanel()
    {
        ChangeNamePanel.SetActive(false );
    }
}
