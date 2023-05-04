using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public TMP_Text textScore;
    public static int diem = 0;
    public static int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + diem + "\nHighScore: " + highScore;
    }
}
