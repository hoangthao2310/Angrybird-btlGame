using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    public float defend;

    public GameObject gameOverObj;
    public GameObject nextGameObj;

    public int scoreMin;


    //Xu ly va cham
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude >= defend)
        {
            Destroy(gameObject, 0.1f);
            score.diem += 100;
            GameOver();
            if (score.diem > score.highScore)
            {
                score.highScore = score.diem;
                PlayerPrefs.SetInt("HighScore", score.diem);
            }
        }
        else
        {
            defend -= collision.relativeVelocity.magnitude;
        }

    }
    void GameOver()
    {
        if (score.diem >= scoreMin)
        {
            nextGameObj.SetActive(true);
            gameOverObj.SetActive(false);
        }
        else
        {
            gameOverObj.SetActive(true);
            nextGameObj.SetActive(false);
        }
    }
}
