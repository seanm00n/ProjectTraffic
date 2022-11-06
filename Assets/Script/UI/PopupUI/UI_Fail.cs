using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_Fail : UI_Popup
{
    enum GameObjects
    {
        FailPannel,
        FailImage,
        FailTextImage,
        RetryButton,
        ExitButton
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.RetryButton).BindEvent(OnRetryEvent);
        Get<GameObject>((int)GameObjects.ExitButton).BindEvent(OnExitEvent);
    }

    void OnRetryEvent(PointerEventData evt)
    {
        GameManager.Scene.ReLoadScene();
    }
    void OnExitEvent(PointerEventData evt)
    {
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
    }
}
