using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
 
class LoadAsset : MonoBehaviour
{
    public GameObject parent = null;
    public string url = null;
    public string prefabName = null;
    public Vector3 rotation = new Vector3(0f,0f,0f);
    void Start()
    {
        StartCoroutine(GetAssetBundle());
    }

    IEnumerator GetAssetBundle()
    {
        Debug.Log("entrou");
        UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(url);
        Debug.Log("baixando objeto 3d");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log(url);
            AssetBundle bundle = ((DownloadHandlerAssetBundle)www.downloadHandler).assetBundle;
            GameObject duck = (GameObject)bundle.LoadAsset(prefabName);
            Debug.Log(parent.transform);
            duck.transform.Rotate(rotation);
            Debug.Log(duck.transform);
            Instantiate(duck,parent.transform);
            
        }
    }
}