using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMinu : MonoBehaviour
{
    

    
    public void LoadMain()
    {
        SceneManager.LoadScene("Main minu");
    }

    public void Reload()
    {
        SceneManager.LoadScene("The Game");
    }

    
}
