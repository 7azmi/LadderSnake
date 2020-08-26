using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    [SerializeField]
    public bool testMode = false;
    static string google_ID = "3709275";
    string myPlacementId = "rewardedVideo";

    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(google_ID, false);

            
    }

    public static void ShowAd()
    {
        Advertisement.Show();
    }
    public void ShowRewordedAd()
    {
        Advertisement.Show(myPlacementId);
    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            print("DONE");

            Manager.Board_Card.Locked = false;
            //music
        }
        else if (showResult == ShowResult.Skipped)
        {
            print("Skipped");

            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            print("Failed");

            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }
    #region blablabla
    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            // Optional actions to take when the placement becomes ready(For example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
    #endregion
}
