using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    //public string URL = "https://github.com/Kekbabus/Projectrepo_endsem";
    public void GoToSene1()
    {
        SceneManager.LoadScene("First Level");
    }


    /*public void loadUrl()
    {
        Application.OpenURL(URL);
    }*/
}
