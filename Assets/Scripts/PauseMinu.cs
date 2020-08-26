using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMinu : MonoBehaviour
{
    

    
    public void LoadMain()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadScene("Main minu");
    }

    public void Reload()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadScene("The Game");
    }

    
}
