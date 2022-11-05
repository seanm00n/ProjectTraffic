using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager
{
    Stack<UI_Popup> _stack = new Stack<UI_Popup>();
    UI_Scene _scene;

    public T ShowSceneUI<T>(string name = null) where T : UI_Scene
    {
        if (name == null)
        {
            name = typeof(T).Name;
        }

        GameObject go = GameManager.Resource.Instantiate($"UI/Scene{name}");
        T SceneUI = go.GetOrAddComponent<T>();
        _scene = SceneUI;

        return SceneUI;
    }

    public T ShowPopupUI<T>(string name = null) where T : UI_Popup
    {
        if (name == null)
        {
            name = typeof(T).Name;
        }

        GameObject go = GameManager.Resource.Instantiate($"UI/Popup{name}");
        T PopipUI = go.GetOrAddComponent<T>();
        _stack.Push(PopipUI);

        return PopipUI;
    }

    public void ClosePopupUI()
    {
        if (_stack.Count == 0)
            return;

        UI_Popup popup = _stack.Pop();
        GameManager.Resource.Destroy(popup.gameObject);

        popup = null;
    }

    public void CloseAllPopupUI()
    {
        while (_stack.Count > 0)
        {
            ClosePopupUI();
        }
    }
}