using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class GoogleLogin : MonoBehaviour
{
    public string authState = "Not Tried";
    bool auth;
    
    // Use this for initialization
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
            // requests an ID token be generated.  This OAuth token can be used to
            //  identify the player to other services such as Firebase.
         //   .RequestIdToken()
         //   .Build();

        PlayGamesPlatform.InitializeInstance(config);

        // recommended for debugging 
        PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SingUpOrLogin()
    { 
        Social.localUser.Authenticate(success =>
        {
            auth = success;

            authState = auth ? "Success Auth" : "Fail Auth";

            UIUpdator.UpdateUI();
        });
    }

    public void SignOut()
    {
        PlayGamesPlatform.Instance.SignOut();
        authState = "SignOut";
        UIUpdator.UpdateUI();
    }
}
