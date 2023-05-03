using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string playerName = nameInput.text;
        PlayerPrefs.SetString("PlayerName", playerName);
    }
    public static void OpenScene()
    {
        SceneManager.LoadScene(1);
    }
}
