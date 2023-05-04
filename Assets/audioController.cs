using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{
    AudioSource audioSource;
    int MusicBackground;
    public Toggle MusicBackgroundCheck;
    // Start is called before the first frame update
    void Start()
    {

        MusicBackground = PlayerPrefs.GetInt("MusicBackground");
        audioSource = GetComponent<AudioSource>();
        if (MusicBackground == 1)
        {
            audioSource.Play();
            MusicBackgroundCheck.isOn = true;
        }
        else
        {
            audioSource.Stop();
            MusicBackgroundCheck.isOn = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (audioSource.isPlaying)
            {
                audioSource.Pause();
            }
            else
            {
                audioSource.Play();
            }

        }
    }
    public void OnOffMusicBackground()
    {
        if (MusicBackgroundCheck.isOn == false)
        {
            if (audioSource != null)
            {
                audioSource.Pause();
            }
            PlayerPrefs.SetInt("MusicBackground", 0);
        }
        else
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
            PlayerPrefs.SetInt("MusicBackground", 1);
        }
    }
}
