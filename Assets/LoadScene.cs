using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("PlayerName", playerName.text); // lưu tên người dùng vào PlayerPrefs
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void OpenScene()
    {
        SceneManager.LoadScene(1);
    }
}
