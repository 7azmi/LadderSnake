using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class PixelPerfectCameraModifier : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<UnityEngine.U2D.PixelPerfectCamera>().refResolutionX = Screen.width;
        GetComponent<UnityEngine.U2D.PixelPerfectCamera>().refResolutionY = Screen.height;
    }
}
