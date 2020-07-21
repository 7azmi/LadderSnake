using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour
{
    static string google_ID = "3709275";
    // Start is called before the first frame update
    static void Start()
    {
        Advertisement.Initialize(google_ID);
            
    }

    public static void ShowAd()
    {
        Advertisement.Show();
    }
    public void ShowAd2()
    {
        Advertisement.Show();
    }
}
