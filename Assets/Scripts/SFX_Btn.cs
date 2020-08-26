using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_Btn : MonoBehaviour
{
    Button button;


    void Start()
    {
        button = GetComponent<Button>();

        if (AudioManager.SFX_disabled)
        {
            button.image.color = Color.gray;
        }
        else
        {
            button.image.color = Color.white;
        }
    }

    public void SFX_Toggle()
    {
        if (AudioManager.SFX_disabled)
        {

            AudioManager.SFX_disabled = false;
            PlayerPrefs.SetInt("SFX", 0);
            button.image.color = Color.white;

        }
        else
        {
            AudioManager.SFX_disabled = true;
            PlayerPrefs.SetInt("SFX", 1);
            button.image.color = Color.gray;
        }
    }



}
