using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class downloadImage : MonoBehaviour
{
    public string url = "";
    public Renderer thisRenderer;
    public GameObject child;
    public GameObject parent;
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine());

    }
    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("loading");
        UnityWebRequest wwwloader = UnityWebRequestTexture.GetTexture(url);
        yield return wwwloader.SendWebRequest();
        Debug.Log("loaded");
        thisRenderer.material.color = Color.white;
        thisRenderer.material.mainTexture = ((DownloadHandlerTexture)wwwloader.downloadHandler).texture;
        child.transform.parent = parent.transform;
    }
   
}
