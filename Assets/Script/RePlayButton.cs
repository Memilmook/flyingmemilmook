using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;

public class RePlayButton : MonoBehaviour
{
    private InterstitialAd interstitial;
    public Canvas myCanvas;
    public void ReplayGame()
    {
        RequestInterstitial();
        StartCoroutine(showInterstitial());

        IEnumerator showInterstitial()
        {
            while (!this.interstitial.IsLoaded())
            {
                yield return new WaitForSeconds(0.2f);
            }
            this.interstitial.Show();
            myCanvas.sortingOrder = -1;
        }
    }

    public void ReturnMain()
    {
        SceneManager.LoadScene("WaitingRoomScene");
    }



    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = admobAdId.frontAdId;
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);
        this.interstitial.OnAdClosed += HandleOnAdClosed;

        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

    public void HandleOnAdClosed(object sender, System.EventArgs args)
    {
        SceneManager.LoadScene("PlayScene");
    }
}
