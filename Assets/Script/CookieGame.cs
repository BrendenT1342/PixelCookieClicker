using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class CookieGame : MonoBehaviour
{
    public int cookie;
    public int multiply;
    public TMP_Text NumberCookies;

    // Start is called before the first frame update
    void Start()
    {
        //Beginning of the game you start with 0 cookie and clicks gives you 1 cookie.
        multiply = PlayerPrefs.GetInt("multiply",1);
        cookie = PlayerPrefs.GetInt("cookie",0);
    }

    // Update is called once per frame
    void Update()
    {
        NumberCookies.text = "Cookie: " + cookie;

        //This is for restarting the game(current cookies) and require to exit the game.
        if(Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    #region
    //This function is the cookie button for players to click the cookie.
    public void CookieClickButton()
    {
        cookie += multiply;
        PlayerPrefs.SetInt("cookie", cookie);
    }
    #endregion

    #region
    //Players can buy upgrades from the shops. Whenever the player has the number of cookies require can purchase these upgrades.
    public void Shop(int upgrade)
    {
        
        if (upgrade == 1 && cookie >= 20)
        {
            multiply += 1;
            cookie -= 20;
            PlayerPrefs.SetInt("cookie", cookie);
            PlayerPrefs.SetInt("multiply", multiply);
        }
        if (upgrade == 2 && cookie >= 50) 
        { 
            multiply += 10;
            cookie -= 50;
            PlayerPrefs.SetInt("cookie", cookie);
            PlayerPrefs.SetInt("multiply", multiply);
        }
        if (upgrade == 3 && cookie >= 100)
        {
            multiply += 50;
            cookie -= 100;
            PlayerPrefs.SetInt("cookie", cookie);
            PlayerPrefs.SetInt("multiply", multiply);
        }
        if (upgrade == 4 && cookie >= 5000)
        {
            multiply += 100;
            cookie -= 5000;
            PlayerPrefs.SetInt("cookie", cookie);
            PlayerPrefs.SetInt("multiply", multiply);
        }
        
    }
    #endregion
}