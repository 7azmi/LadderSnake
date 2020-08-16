using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX_Btn : MonoBehaviour
{
    AudioManager am;

    private void Start()
    {
        am = FindObjectOfType<AudioManager>();
    }
    public void Toggle()
    {
        if (am.gameObject.activeInHierarchy) am.gameObject.SetActive(false);
        else am.gameObject.SetActive(true);
        //am.gameObject.activeInHierarchy
    }
}
