using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class namePlayer : MonoBehaviour
{
    public TMP_Text playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        string playerName = PlayerPrefs.GetString("PlayerName");
        if (string.IsNullOrEmpty(playerName))
        {
            playerNameText.text = "Xin ch�o!";
        }
        else
        {
            playerNameText.text = "Xin ch�o " + playerName + "!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
