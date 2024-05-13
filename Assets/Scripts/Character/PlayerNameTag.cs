using UnityEngine;
using UnityEngine.UI;

public class PlayerNameTag : MonoBehaviour
{
    [SerializeField] private Text nameTag;

    private void Awake()
    {
        nameTag.text = PlayerPrefs.GetString("PlayerName");
    }

    private void FixedUpdate()
    {
        nameTag.transform.position = transform.position+ Vector3.up;
    }
}
