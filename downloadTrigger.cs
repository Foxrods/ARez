using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class downloadTrigger : MonoBehaviour
{
    public string[] url = new string[6] { "https://i.imgur.com/WouPdMg.png", "https://i.imgur.com/MfAOgs6.jpg", "https://i.imgur.com/XO8zenG.jpg",
        "https://i.imgur.com/DJJZWTs.jpg","https://i.imgur.com/eXmQrvD.jpg","https://i.imgur.com/WrJ9qrM.jpg" };
       
    
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine());

    }
    private IEnumerator LoadFromLikeCoroutine()
    {
        for(int i=0; i< 6; i++)
        {
            int k = i + 1;
            string savePath = Application.persistentDataPath + "/"+k+".jpg";
            Debug.Log("loading: "+savePath);
            WWW wwwloader = new WWW(url[i]);
            yield return wwwloader;
            Texture2D texture = wwwloader.texture;
            Debug.Log("ok");
            byte[] _bytes = texture.EncodeToJPG();
            System.IO.File.WriteAllBytes(savePath, _bytes);
            Debug.Log(_bytes.Length / 1024 + "Kb was saved as: " + savePath);
        }
        


    }
    
}
