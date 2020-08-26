using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music_Btn : MonoBehaviour
{
    Button button;

    void Awake()
    {
        button = GetComponent<Button>();
    }

    void Start()
    {
        
        if (AudioManager.music_disabled)
        {
            button.image.color = Color.gray;

        }
        else
        {
            button.image.color = Color.white;
        }

    }

    
    public void Music_Toggle()
    {
        if (!AudioManager.music_disabled)
        {

            AudioManager.instance.StopMusic();
            button.image.color = Color.gray;
            AudioManager.music_disabled = true;
            PlayerPrefs.SetInt("Music", 1);

        }
        else
        {
            
            button.image.color = Color.white;
            AudioManager.music_disabled = false;
            PlayerPrefs.SetInt("Music", 0);
            AudioManager.instance.Play(MusicTrigger.sceneName);
        }
    }
}
