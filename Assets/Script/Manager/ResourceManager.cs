using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{

    // 랩핑
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }
    

    // Instance랩핑 및 예외처리
    public GameObject Instantiate(string path)
    {
        GameObject prefeb = Load<GameObject>($"Prefeb/{path}");

        if (prefeb == null)
        {
            Debug.Log($"{path} is wrong path");
            return null;
        }

        GameObject go = Object.Instantiate(prefeb);
        
        return go;
    }

    // Destroy랩핑 및 예외처리
    public void Destroy(GameObject go)
    {
        if (go == null)
        {
            Debug.Log($"{go} is wrong game object");
            return;
        }
        Destroy(go.gameObject);
    }
}
