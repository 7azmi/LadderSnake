using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicTrigger : MonoBehaviour
{
    public static string sceneName
    {
        get { return SceneManager.GetActiveScene().name; }
        //set { SceneManager.GetActiveScene().name = value; }
    }
    void Start()
    {
        if (!AudioManager.music_disabled) AudioManager.instance.PlayMusic();
        //print(sceneName);
    }

}
