using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BaseScene : MonoBehaviour
{
    void Awake()
    {
        Init();
    }

    protected virtual void Init()
    {
        Object obj = Object.FindObjectOfType(typeof(EventSystem));

        if (obj == null)
        {
            obj = GameManager.Resource.Instantiate("UI/@EventSystem");
        }
    }
}
