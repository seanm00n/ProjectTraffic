using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_PopupMenu : UI_Popup
{
    enum GameObjects
    {
        MenuPannel,
        GoToMenuButton,
        RetryButton,
        ContinueButton
    }

    private void Start()
    {
        Init();
    }

    protected override void Init()
    {
        base.Init();

        Bind<GameObject>(typeof(GameObjects));

        Get<GameObject>((int)GameObjects.GoToMenuButton).BindEvent(OnMenuClicked);
        Get<GameObject>((int)GameObjects.RetryButton).BindEvent(OnRetryClicked);
        Get<GameObject>((int)GameObjects.ContinueButton).BindEvent(OnContinueClicked);
    }

    void OnMenuClicked(PointerEventData evt)
    {
        Time.timeScale = 1;
        GameManager.Scene.LoadScene(Define.Scene.MainScene);
        
    }
    void OnRetryClicked(PointerEventData evt)
    {
        Time.timeScale = 1;
        GameManager.Scene.ReLoadScene();
    }
    void OnContinueClicked(PointerEventData evt)
    {
        Time.timeScale = 1;
        GameManager.UI.ClosePopupUI();
    }
}
