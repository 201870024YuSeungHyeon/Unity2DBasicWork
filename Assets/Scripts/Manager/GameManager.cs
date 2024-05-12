using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private string playerTag;

    public Transform Player { get; private set; }

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


    void Update()
    {
       if(Player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag(PlayerPrefs.GetString("selectedOption"));
            if(playerObject != null )
            {
                Player = playerObject.transform;
            }
        }
    }
}
