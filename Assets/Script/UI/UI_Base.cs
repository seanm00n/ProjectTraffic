using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

<<<<<<<< HEAD:Assets/Script/Lane.cs
public class Lane : MonoBehaviour
========
public class UI_Base : MonoBehaviour
>>>>>>>> 742b1ec7323b96893097c7239163dcc1e06cc464:Assets/Script/UI/UI_Base.cs
{
    protected Dictionary<Type, UnityEngine.Object[]> _objects = new Dictionary<Type, UnityEngine.Object[]>();

    protected void Bind<T>(Type _type) where T : UnityEngine.Object
    {
        string[] names = Enum.GetNames(_type);
        UnityEngine.Object[] objects = new UnityEngine.Object[names.Length];
        _objects.Add(typeof(T), objects);

        for (int i = 0; i < names.Length; i++)
        {
            if (typeof(T) == typeof(GameObject))
            {
                objects[i] = gameObject.FindChild(names[i], true);
            }
            else
            {
                objects[i] = gameObject.FindChild<T>(names[i], true);
            }
        }
    }

    protected T Get<T>(int idx) where T : UnityEngine.Object
    {
        UnityEngine.Object[] objects = null;

        if (_objects.TryGetValue(typeof(T), out objects))
        {
            return null;
        }

        return objects[idx] as T;
    }

    public static void BindEvent(GameObject go, Action<PointerEventData> action, Define.UIEvent type = Define.UIEvent.Click)
    {
        UI_EventHandler Event = go.GetOrAddComponent<UI_EventHandler>();

        switch (type)
        {
            case Define.UIEvent.Click:
                Event.OnClicked -= action;
                Event.OnClicked += action;
                break;
        }

    }
}