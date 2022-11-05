using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Util
{
    public T GetOrAddComponent<T>(GameObject go) where T : Component
    {
        T component = go.GetComponent<T>();

        if (component == null)
        {
            component = go.AddComponent<T>();
        }

        return component;
    }

    public T FindChild<T>(GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        if (recursive)
        {
            foreach(T component in go.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(name) || component.name == name)
                {
                    return component;
                }
            }
        }
        else
        {
            for (int i = 0; i < go.transform.childCount; ++i)
            {
                Transform transform = go.transform.GetChild(i);

                if (string.IsNullOrEmpty(name) || transform.name == name)
                {
                    T component = transform.GetComponent<T>();
                    if (component)
                    {
                        return component;
                    }
                }
            }
        }

        return null;
    }

    public GameObject FindChild(GameObject go, string name = null, bool recursive = false)
    {
        return FindChild<GameObject>(go, name, recursive);
    }
}
