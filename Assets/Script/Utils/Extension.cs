using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extension
{
    static public T GetOrAddComponent<T>(this GameObject go) where T : Component
    {
        return GetOrAddComponent<T>(go);
    }

    static public T FindChild<T>(this GameObject go, string name = null, bool recursive = false) where T : UnityEngine.Object
    {
        return FindChild<T>(go, name, recursive);
    }

    static public GameObject FindChild(this GameObject go, string name = null, bool recursive = false)
    {
        return FindChild(go, name, recursive);
    }
}
