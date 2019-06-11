using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Change2AR : MonoBehaviour
{
    public InputField user;
    public InputField password;
    public void changescene() { 
        if(user.text == "b2t" && password.text == "starwars")
        {
            System.Threading.Thread.Sleep(2000);
            SceneManager.LoadScene("SampleScene");
        }
        
    }
}
