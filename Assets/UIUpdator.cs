using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdator : MonoBehaviour {
    static bool update;

    public Text fireBaseAuthState;
    public Text googleLoginAuthState;

    Auth auth;
    GoogleLogin googleLogin;

    private void Awake()
    {
        auth = GetComponent<Auth>();
        googleLogin = GetComponent<GoogleLogin>();
    }

    void Update()
    {
        if(update)
        {
            update = false;

            googleLoginAuthState.text = googleLogin.authState;
        }
    }

    static public void UpdateUI()
    {
        update = true;
    }
}
