using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager
{

    // ����
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }
    

    // Instance���� �� ����ó��
    public GameObject Instantiate(string path, Vector2 _position)
    {
        GameObject prefeb = Load<GameObject>($"Prefab/{path}");

        if (prefeb == null)
        {
            Debug.Log($"Prefab/{path} is wrong path");
            return null;
        }

        GameObject go = Object.Instantiate(prefeb);
        go.transform.position = _position;
        
        return go;
    }

    public GameObject Instantiate(string path)
    {
        return Instantiate(path, Vector2.zero);
    }

    // Destroy���� �� ����ó��
    public void Destroy(GameObject go)
    {
        if (go == null)
        {
            Debug.Log($"{go} is wrong game object");
            return;
        }
        Object.Destroy(go.gameObject);
    }
}
